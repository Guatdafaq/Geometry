using Geometry.Points;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Figures
{
    public abstract class GeometryFigure<T>
    {

        #region [ Variables ]
        protected Type _listType = typeof(T);
        protected List<T> _points;
        protected double _area;
        protected bool _2D;
        #endregion

        #region  [ Constructors ]
        /// <summary>
        /// Constructor of a Geometry Figure.
        /// </summary>
        public GeometryFigure()
        {
            if (_listType == typeof(Point2D)) _2D = true; else _2D = false;
            _area = 0;
        }
        #endregion

        #region [ Properties ]

        #endregion

        #region [ Methods ]
        /// <summary>
        /// Calcula el área del polígono.
        /// </summary>
        /// <returns>Área del polígono.</returns>
        public abstract double Area();

        /// <summary>
        /// Calcula el perímetro del polígono.
        /// </summary>
        /// <returns>Perímetro del polígono.</returns>
        public abstract double Perimeter();
        #endregion

        #region [ Utilities ]

        #endregion

    }
}
