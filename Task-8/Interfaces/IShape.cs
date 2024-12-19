using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8.Interfaces
{
    internal interface IShape
    {
        #region Property & Attribute
        public Double GetArea();

        void Display();
        #endregion
    }

  
    public class Circle : IShape
    {
        #region Property & Attribute
        double radius { get; set; }
        #endregion

        #region Constructor
        public Circle(double _radius)
        {
            radius = _radius;
        }
        #endregion

        #region Methods
        public Double GetArea()
        {
          return radius * radius * 3.14156;
        }

        public void Display()
        {
            Console.WriteLine("The shape is circle");
        }
        #endregion
    }
    public class Rectangle : IShape
    {
        #region Properties & Attributes
        public double Length { get; set; }
        public double Width { get; set; }
        #endregion

        #region Constructor
        public Rectangle(double _Length, double _Width)
        {
            Length = _Length;
            Width = _Width;
        }
        #endregion

        #region Methods
        public void Display()
        {
           Console.WriteLine("The sha[e is rectangle");
        }

        public Double GetArea()
        {
           return Length*Width;
        }
        #endregion
    }
}
