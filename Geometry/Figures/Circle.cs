using Geometry.Points;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Figures
{
    public class Circle<T> : GeometryFigure<T>
    {

        #region [ Variables ]
        double _radius;
        T _center;
        #endregion

        #region  [ Constructors ]
        /// <summary>
        /// Constructor of a Circle.
        /// </summary>
        /// <param name="center">Center of the circle</param>
        /// <param name="radius">Radius of the circle</param>
        public Circle(T center, double radius) : base()
        {
            _center = center;
            _radius = radius;
        }
        #endregion

        #region [ Properties ]
        /// <summary>
        /// Circle's center
        /// </summary>
        public T Center { get { return _center; } }

        /// <summary>
        /// Circle's radius
        /// </summary>
        public double Radius { get { return _radius; } }
        #endregion

        #region [ Methods ]
        public override double Area()
        {
            return _area = Math.PI * Math.Pow(_radius, 2);
        }

        public override double Perimeter()
        {
            return Math.PI * 2 * _radius;
        }
        #endregion

        #region [ Utilities ]
        public override string ToString()
        {
            return string.Format("Centro: {1}{0}Radio: {2}{0}", Environment.NewLine, _center, _radius);
        }

        public override bool Equals(object obj)
        {
            bool equal = false;
            Circle<T> circle = obj as Circle<T>;
            if (this.Area() == circle.Area())
                equal = true;
            return equal;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

    }
}
