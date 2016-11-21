using Geometry.Points;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Vectors
{
    public class Vector2D
    {

        #region [ Variables ]
        private Point2D _p1, _p2;
        private double? _module;
        #endregion

        #region  [ Constructors ]
        /// <summary>
        /// Constructor of a 2D Vector.
        /// </summary>
        /// <param name="_p1">Origin 2D point of the vector</param>
        /// <param name="_p2">End 2D point of the vector</param>
        public Vector2D(Point2D _p1, Point2D _p2)
        {
            this._p1 = _p1;
            this._p2 = _p2;
            _module = null;
        }
        #endregion

        #region [ Properties ]
        /// <summary>
        /// Módulo del vector.
        /// </summary>
        public double Module
        {
            get
            {
                return (double)(_module = _module ?? Math.Sqrt(Math.Pow((_p2.X - _p1.X), 2) + Math.Pow((_p2.Y - _p1.Y), 2)));
            }
        }

        /// <summary>
        /// Devuelve el punto 1 del vector
        /// </summary>
        public Point2D P1 { get { return _p1; } }
        /// <summary>
        /// Devuelve el punto 2 del vector
        /// </summary>
        public Point2D P2 { get { return _p2; } }
        /// <summary>
        /// Devuelve la componente X del vector
        /// </summary>
        public double X { get { return _p2.X - _p1.X; } }
        /// <summary>
        /// Devuelve la componente Y del vector
        /// </summary>
        public double Y { get { return _p2.Y - _p1.Y; } }
        #endregion

        #region [ Methods ]

        #endregion

        #region [ Utilities ]
        public override string ToString()
        {
            return string.Format("Inicio: {1}{0} Final: {2}{0} Vector: ({3}, {4}){0}", Environment.NewLine, _p1, _p2, X, Y);
        }

        public override bool Equals(object obj)
        {
            bool equal = false;
            Vector2D vector = obj as Vector2D;
            if (this._p1 == vector.P1 && this._p2 == vector.P2)
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
