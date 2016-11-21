using Geometry.Points;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Vectors
{
    public static class Utilities
    {

        #region [ Variables ]

        #endregion

        #region [ Properties ]

        #endregion

        #region [ Methods ]

        #endregion

        #region [ Utilities ]
        /// <summary>
        /// Calcula el productor vectorial de dos vectores 2D
        /// </summary>
        /// <param name="v1">Vector 1</param>
        /// <param name="v2">Vector 2</param>
        /// <returns></returns>
        public static Vector2D CrossVector(Vector2D v1, Vector2D v2)
        {
            return v1;
        }

        /// <summary>
        /// Calcula el productor vectorial de dos vectores 3D
        /// </summary>
        /// <param name="v1">Vector 1</param>
        /// <param name="v2">Vector 2</param>
        /// <returns></returns>
        public static Vector3D CrossVector(Vector3D v1, Vector3D v2)
        {
            double X = (v1.Y * v2.Z) - (v1.Z * v2.Y);
            double Y = (v1.X * v2.Z) - (v1.Z * v2.X);
            double Z = (v1.X * v2.Y) - (v1.Y * v2.X);

            return new Vector3D(new Point3D(0, 0, 0), new Point3D(X, Y, Z));
        }
        #endregion

    }
}
