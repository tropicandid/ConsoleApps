using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LockedVehicles.Processing;


namespace LockedVehicles
{
    public class Program
    {
        public void Main(string[] args)
        {
          DataManager dataProcessor = new DataManager();
          Console.WriteLine("Enter the lotsource id");

          int lotSourceId;
          Int32.TryParse(Console.ReadLine(), out lotSourceId);

          dataProcessor.GrabDataFromDB(lotSourceId);
        }
    }
}
