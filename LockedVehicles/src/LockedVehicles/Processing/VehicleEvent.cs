using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace LockedVehicles.Processing
{
    public class VehicleEvent 
    {
      public long Position { get; set; }
      public string Type { get; set; }
      public string Json { get; set; }
      public int UserId { get; set; }
    
  }
}
