using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LockedVehicles.Processing
{
    public class LockVehicle : VehicleDataChange
    {
      public DateTime? ExpiresAt { get; set; }
  }
}
