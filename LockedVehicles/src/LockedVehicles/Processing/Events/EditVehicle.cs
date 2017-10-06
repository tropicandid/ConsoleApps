using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LockedVehicles.Processing
{
    public class EditVehicle : VehicleDataChange
  {
    public List<Dictionary<string, string>> Edits { get; set; }
    public  DateTime? ExpiresAt { get; set; }
    }
}
