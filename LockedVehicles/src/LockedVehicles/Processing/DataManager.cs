using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Dapper;
using LockedVehicles.Processing.Events;

namespace LockedVehicles.Processing
{
    public class DataManager
  {
    public List<EventToCompare> _events = new List<EventToCompare>();
    public List<EventToCompare> _finalEvents = new List<EventToCompare>();

    public void GrabDataFromDB(int lotSourceId)
    {
      using (SqlConnection conn = new SqlConnection("#ADD_CONNECTION_STRING#"))
      {
        conn.Open();
        try
        {
          var VehicleEvents = new List<VehicleEvent>();
          VehicleEvents = conn.Query<VehicleEvent>(
          "ADD_SQL_QUERY").ToList();

          CreatAndStoreEventObjects(VehicleEvents);
        }
        catch (Exception e)
        {
          Console.WriteLine(e.Message);
          Console.ReadLine();
        }
      }
    }

    public void CreatAndStoreEventObjects(List<VehicleEvent> Events)
      {
      foreach (var e in Events)
      {
        var position = e.Position;
        var type = e.Type;
        var userId = e.UserId;

        switch (type)
        {
          case "inventory:LockVehicle":
            var lockJson = JsonConvert.DeserializeObject<LockVehicle>(e.Json);
            _events.Add(new EventToCompare(position, userId, lockJson, true));
            break;
          case "inventory:UnlockVehicle":
            var unlockJson = JsonConvert.DeserializeObject<UnlockVehicle>(e.Json);
            _events.Add(new EventToCompare(position, userId, unlockJson, false));
            break;
          case "inventory:EditVehicle":
            var editJson = JsonConvert.DeserializeObject<EditVehicle>(e.Json);
            if (editJson.Edits.Count > 0)
            {
              _events.Add(new EventToCompare(position, userId, editJson, true));
            }
            else
            {
              _events.Add(new EventToCompare(position, userId, editJson, false));
            }
            break;
        }
      }
        CompareEventData();
      }

      public void CompareEventData()
      {
        foreach (var e in _events)
        {
          if (_finalEvents.All(x => x.VEvent.Vin != e.VEvent.Vin))
          {
            var allOfSameVin = _events.Where(item => item.VEvent.Vin == e.VEvent.Vin);
            var mostRecentEventOnVin = allOfSameVin.OrderByDescending(item => item.Position).First();
            _finalEvents.Add(mostRecentEventOnVin);
          }
        }
        FileWriter writer = new FileWriter();
        writer.WriteLockedVehiclesToFile(_finalEvents);
      }
  }
}
