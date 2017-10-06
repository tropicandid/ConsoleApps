using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LockedVehicles.Processing.Events;

namespace LockedVehicles.Processing
{
    public class FileWriter
    {
      private readonly StreamWriter Writer;
      private string FilePath = @"#DESTINATION_FILE_PATH#";

      public FileWriter()
      {
        Writer = new StreamWriter(FilePath);
      }

      public void WriteLockedVehiclesToFile(List<EventToCompare> finalEvents)
      {
      var line = String.Format("{0},{1},{2}", "Vin", "UserId","Date");
      Writer.WriteLine(line);
      foreach (var e in finalEvents)
        {
          if (e.Locked)
          {
            line = String.Format("{0},{1},{2}", e.VEvent.Vin, e.UserId, e.VEvent.When);
            Writer.WriteLine(line);
          }
        }
      Writer.Close();
      }
    }
}
