using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LockedVehicles.Processing
{
    public class VehicleDataChange
    {
      public int LotSourceId { get; set; }
      public string Vin { get; set; }
      public DateTime When { get; set; }
    }
}
