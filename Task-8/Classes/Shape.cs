using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal abstract class Shape
    {
        #region Methods
        public abstract Double GetArea();

        public abstract void Display();
        #endregion

  
    }
    class circle : Shape
    {
        #region Properties & Attributes
        public double Radius { get; set; }
        #endregion

        #region Constructor
        public circle (double _radius)
        {
            Radius = _radius;
        } 
        #endregion

        #region Methods
        public override Double GetArea()
        {
            return Radius * Radius * 3.14156;
        }

        public override void Display()
        {
            Console.WriteLine("The shape is circle");
        }
        #endregion
       
    }
    class rectangle : Shape
    {
        #region Properties & Attributes
        public double Width { get; set; }
        public double Length { get; set; }
        #endregion

        #region Constructor
        public rectangle(double _Length,double _Width)
        {
            Length = _Length;
            Width = _Width;
        }
        #endregion

        #region Methods
        public override Double GetArea()
        {
          return Length*Width ;
        }
        public override void Display()
        {
            Console.WriteLine("The shape is rectangle");
        }
        #endregion
       
    }
}
