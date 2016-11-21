using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Points
{
    public class Point3D : Point2D
    {

        #region [ Variables ]
        private double _z;
        #endregion

        #region  [ Constructors ]
        /// <summary>
        /// Constructor of a 3D Point.
        /// </summary>
        /// <param name="x">Coordinate X</param>
        /// <param name="y">Coordinate Y</param>
        /// <param name="z">Coordinate Z</param>
        public Point3D(double x, double y, double z) : base(x, y)
        {
            Z = z;
        }
        #endregion

        #region [ Properties ]
        /// <summary>
        /// X coordinate of the point.
        /// </summary>
        public new double X { get { return _x; } set { this._x = value; _longitud = Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2) + Math.Pow(_z, 2)); } }
        /// <summary>
        /// Y coordinate of the point
        /// </summary>
        public new double Y { get { return _y; } set { this._y = value; _longitud = Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2) + Math.Pow(_z, 2)); } }
        /// <summary>
        /// Z coordinate of the point.
        /// </summary>
        public double Z { get { return _z; } set { this._z = value; _longitud = Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2) + Math.Pow(_z, 2)); } }
        #endregion

        #region [ Methods ]

        #endregion

        #region [ Utilities ]
        override public string ToString() { return ($"({_x}, {_y}, {_z})"); }
        public override bool Equals(object obj)
        {
            bool equal = false;
            Point3D point = obj as Point3D;
            if (this._x == point.X && this._y == point.Y && this._z == point.Z)
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
