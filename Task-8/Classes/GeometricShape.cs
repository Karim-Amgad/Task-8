using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
     public abstract class GeometricShape
    {
        #region Attributes & Properties
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }

        public abstract double Perimeter { get; }
        #endregion
        #region Methods
        public abstract double CalculateArea();
        #endregion
    }
    public class Triangle3 : GeometricShape
    {
        #region Constructor
        public Triangle3(double _Length, double _Height)
        {
            Dimension1 = _Length;  
            Dimension2 = _Height;     
        }
        #endregion
        public override double Perimeter
        { get
          { double Dimension3 = Math.Sqrt(Dimension1*Dimension1 + Dimension2*Dimension2);
            return Dimension1 + Dimension2 + Dimension3; }
        }
       
        public override double CalculateArea()
        {
            return 0.5*Dimension1*Dimension2;
        }
    }
    public class Rectangle3 : GeometricShape
    {
        #region Constructor
        public Rectangle3(double _Length, double _Height)
        {
            Dimension1 = _Length;
            Dimension2 = _Height;
        }
        #endregion
        public override double Perimeter
        {
            get
            {
                return Dimension1*2 + Dimension2*2;
            }
        }

        public override double CalculateArea()
        {
            return Dimension1*Dimension2;
        }
    }
}
