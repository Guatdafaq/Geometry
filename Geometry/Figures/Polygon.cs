using Geometry.Points;
using Geometry.Vectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Figures
{
    public class Polygon<T> : GeometryFigure<T>
    {

        #region [ Variables ]
        protected double _perimeter;
        #endregion

        #region  [ Constructors ]
        /// <summary>
        /// Constructor of a Polygon.
        /// </summary>
        public Polygon() : base() { }
        #endregion

        #region [ Properties ]
        public List<T> Points { get { return _points; } }
        #endregion

        #region [ Methods ]
        public override double Area()
        {
            _area = 0;
            int j = _points.Count() - 1;  // The last vertex is the 'previous' one to the first

            if (_2D)
                for (int i = 0; i < _points.Count(); i++)
                {
                    _area += (Math.Abs(((_points[j] as Point2D).X + (_points[i] as Point2D).X) * ((_points[j] as Point2D).Y - (_points[i] as Point2D).Y))) / 2;
                    j = i;  //j is previous vertex to i
                }
            else
            {
                Point3D reference = _points[0] as Point3D;
                for (int i = 1; i < _points.Count() - 2; i++)
                {
                    Vector3D vector1 = new Vector3D(reference, _points[i] as Point3D);
                    Vector3D vector2 = new Vector3D(reference, _points[i + 1] as Point3D);
                    Vector3D result = Utilities.CrossVector(vector1, vector2);
                    _area += result.Module / 2;
                }
            }
            return _area;
        }
        public override double Perimeter()
        {
            _perimeter = 0;
            for (int i = 0; i < _points.Count() - 1; i++)
            {
                if (_2D)
                {
                    Vector2D side = new Vector2D(_points[i] as Point2D, _points[i + 1] as Point2D);
                    _perimeter += side.Module;
                }
                else
                {
                    Vector3D side = new Vector3D(_points[i] as Point3D, _points[i + 1] as Point3D);
                    _perimeter += side.Module;
                }
            }
            return _perimeter;
        }
        #endregion

        #region [ Utilities ]
        public override string ToString()
        {
            return string.Format("{0}", _points);
        }
        public override bool Equals(object obj)
        {
            bool equal = false;
            Polygon<T> polygon = obj as Polygon<T>;
            if (this._points == polygon.Points)
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
