using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Points
{
    public class Point2D
    {

        #region [ Variables ]
        protected double _x;
        protected double _y;
        protected double _longitud = 0;
        #endregion

        #region  [ Constructors ]
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">Coordinate X</param>
        /// <param name="y">Coordinate Y</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
        #endregion

        #region [ Properties ]
        /// <summary>
        /// X coordinate of the point.
        /// </summary>
        public double X { get { return _x; } set { this._x = value; _longitud = Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2)); } }
        /// <summary>
        /// Y coordinate of the point
        /// </summary>
        public double Y { get { return _y; } set { this._y = value; _longitud = Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2)); } }
        /// <summary>
        /// Distance between origin and the point
        /// </summary>
        /// /*Equals to public double Longitud { get { return _longitud; } } */
        public double Longitud => _longitud;
        #endregion

        #region [ Methods ]

        #endregion

        #region [ Utilities ]
        // If you use the $, the variables between {} call their .ToString() method.
        override public string ToString() { return ($"({_x}, {_y})"); }

        public override bool Equals(object obj)
        {
            bool equal = false;
            Point2D point = obj as Point2D;
            if (this._x == point.X && this._y == point.Y)
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
