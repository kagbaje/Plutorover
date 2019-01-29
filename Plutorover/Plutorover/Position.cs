using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace Plutorover
{

//class Position
   // {
        public struct Vector
        {
            public int x, y;

            public Vector(int xpoint, int ypoint)
            {
                x = xpoint;
                y = ypoint;
            }

            public static double AngleBetween(Vector vector2, Vector vector1)
            {
                double sin = vector1.x * vector2.y - vector2.x * vector1.y;
                double cos = vector1.x * vector2.x + vector1.y * vector2.y;

                return Math.Atan2(sin, cos) * (180 / Math.PI);
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

   // }
}


