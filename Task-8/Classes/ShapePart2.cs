using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal class ShapePart2 : IComparable<ShapePart2>
    {
        #region Properties & Attributes
        public string Name { get; set; }
        public double Area { get; set; }
        #endregion
        #region Constructor
        public ShapePart2(string _Name, double _Area)
        {
            Name = _Name;
            Area = _Area;
        }

        public int CompareTo(ShapePart2 other)
        {
            if (other == null) 
                return 1;

            return this.Area.CompareTo(other.Area);
        }

        #endregion
        public class Square2 : ShapePart2
        {
            public double SideLength { get; set; }

            public Square2(double _SideLength) : base("Square", _SideLength * _SideLength)
            {
                SideLength = _SideLength;
            }
        }

        public class Circle2 : ShapePart2
        {
            public double Radius { get; set; }

            public Circle2(double _Radius) : base("Circle", Math.PI * _Radius * _Radius)
            {
                Radius = _Radius;
            }
        }

        public class Rectangle2 : ShapePart2
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public Rectangle2(double _Width, double _Height) : base("Rectangle", _Width * _Height)
            {
                Width = _Width;
                Height = _Height;
            }
        }
    }
}
