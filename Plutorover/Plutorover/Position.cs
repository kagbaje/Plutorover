using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace Plutorover
{


        public struct Vector
        {
        public int x;
        public int y;

        public Vector(int xpoint, int ypoint)
            {
                x = xpoint;
                y = ypoint;
            }


        public static double AngleBetween(Vector vector1, Vector vector2)
        {
            double sin = vector1.x * vector2.y - vector2.x * vector1.y;
            double cos = vector1.x * vector2.x + vector1.y * vector2.y;
            double ans = Math.Atan2(sin, cos) * (180 / Math.PI);
            double square = ans * ans;
            double sqrt = Math.Sqrt(square);
            return sqrt;
        }





        public static Vector Right(Vector vector)
            {
                Vector vectornew;

                vectornew.x = vector.y;
                vectornew.y = -vector.x;


                return vectornew;
            }


            public static Vector Left(Vector vector)
            {
                Vector vectornew;
                vectornew.x = -vector.y;
                vectornew.y = vector.x;
                return vectornew;
            }


        }
    //class Position
     //{

    // }
}


