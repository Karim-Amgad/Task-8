using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8.Interfaces
{
    internal interface IShapeSeries
    {

        public double CurrentShapeArea { get; set; }

        void GetNextArea();

        void ResetSeries();
    }

    public class SquareSeries : IShapeSeries
    {
        #region Properties & Attributes
        public double CurrentShapeArea { get; set; }
        private int SideLength;
        #endregion

        #region Constructor
        public SquareSeries()
        {
            SideLength = 1;
            CurrentShapeArea = SideLength * SideLength;
        }
        #endregion

        #region Methods
        public void GetNextArea()
        {
            SideLength += 1;
            CurrentShapeArea = SideLength * SideLength;
        }

        public void ResetSeries()
        {
            SideLength=1;
            CurrentShapeArea=1;
        }
        #endregion
       
    }
    public class CircleSeries : IShapeSeries
    {
        #region Properties & Attributes
        public double CurrentShapeArea { get; set; }
        private int Radius;
        #endregion

        #region Constructor
        public CircleSeries()
        {
            Radius = 1;
            CurrentShapeArea = Math.PI * Radius * Radius;
        }
        #endregion

        #region Methods
        public void GetNextArea()
        {
            Radius += 1;
            CurrentShapeArea = Math.PI * Radius * Radius;
        }

        public void ResetSeries()
        {
            Radius = 1;
            CurrentShapeArea = Math.PI * Radius * Radius;
        }
        #endregion

        
    }
}
