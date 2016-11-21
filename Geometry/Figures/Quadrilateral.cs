using Geometry.Points;
using Geometry.Vectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Figures
{
    public class Quadrilateral<T> : Polygon<T>
    {
        #region [ Variables ]

        #endregion

        #region  [ Constructors ]
        /// <summary>
        /// Constructor of a Quadrilateral.
        /// </summary>
        public Quadrilateral() { }
        /// <summary>
        /// Constructor of a Quadrilateral.
        /// </summary>
        /// <param name="p1">First point</param>
        /// <param name="p2">Second point</param>
        /// <param name="p3">Third point</param>
        /// <param name="p4">Fourth point</param>
        public Quadrilateral(T p1, T p2, T p3, T p4) : base()
        {
            _points = new List<T> { p1, p2, p3, p4 };
        }
        #endregion

        #region [ Properties ]

        #endregion

        #region [ Methods ]

        #endregion

        #region [ Utilities ]
        public override string ToString()
        {
            return string.Format("{0}", _points);
        }
        #endregion

    }
}
