using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8.Interfaces
{
    internal interface IVehicle
    {
        #region Methods
        void StartEngine();
        void StopEngine();
        #endregion

    }
    public class Car : IVehicle
    {
        #region Methods
        public void StartEngine()
        {
            Console.WriteLine("The car enigne is started");
        }

        public void StopEngine()
        {
            Console.WriteLine("The car enigne is stopped");
        }
        #endregion
    }
    public class Bike : IVehicle
    {
        #region Methods
        public void StartEngine()
        {
            Console.WriteLine("The bike enigne is started");
        }

        public void StopEngine()
        {
            Console.WriteLine("The bike enigne is stopped");
        }
        #endregion
        
    }
}
