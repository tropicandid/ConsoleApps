using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LockedVehicles.Processing.Events
{
    public class EventToCompare
    {
      public long Position;
      public int UserId;
      public VehicleDataChange VEvent;
      public bool Locked;
      public EventToCompare(long position, int userId, VehicleDataChange vEvent, bool locked)
      {
        Position = position;
        UserId = userId;
        VEvent = vEvent;
        Locked = locked;
      }
    }
}
