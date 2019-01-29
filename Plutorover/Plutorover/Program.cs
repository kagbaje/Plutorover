using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Plutorover
{

    class Program

    {

        Vector north = new Vector(0, 100);
      
        Vector east = new Vector(100, 0);
        
        Vector west = new Vector(-100, 0);
       
        Vector south = new Vector(0, -100);

       
        

        static void Main(string[] args)
        {
            Vector rover = new Vector(0, 0);
           // Backward(rover);

         
         
        





            //need a method that checks for objects, SET OBSTRUCTION 
            //need a method that checks if (WORLD.X > 100 X=-100,WORLD.Y>100 Y=-100 ,WORLD.X<-100 X=100,WORLD.Y<-100, Y=100)
            //need a method for direction


        }

        public static string Direct(Vector roverdir)
        {
            String direction;

            Vector north = new Vector(0, 100);

            Vector east = new Vector(100, 0);

            Vector west = new Vector(-100, 0);

            Vector south = new Vector(0, -100);


            if (Vector.AngleBetween(roverdir, north) == 0)
            {
                direction = "N";

            }
            else if (Vector.AngleBetween(roverdir, south) == 0)
            {
                direction = "S";

            }
            else if (Vector.AngleBetween(roverdir, east) == 0)
            {
                direction = "E";
            }
            else
            {
                direction = "W";

            }
            Console.WriteLine("direction = {0}", direction);
            Console.ReadKey();
            return direction;


        }

        public static Vector Forward(Vector rover)
        {
            string direction = "";
            
            if (direction == "N")
            {
                rover.y++;
            }
            else if (direction == "E")
            {
                rover.x++;
            }
            else if (direction == "W")
            {
                rover.x--;
            }
            else
            {
                rover.y--;
            }
            Console.WriteLine("direction = {0} direction = {1} direction{2}", rover.x,rover.y, direction);
             Console.ReadKey();
            //    return direction;

            return rover;
        }

        public static Vector Backward(Vector rover)
        {
            string direction = "";

            if (direction == "N")
            {
                rover.y--;
            }
            else if (direction == "E")
            {
                rover.x--;
            }
            else if (direction == "W")
            {
                rover.x++;
            }
            else
            {
                rover.y++;
            }
            Console.WriteLine("direction = {0} direction = {1} direction{2}", rover.x, rover.y, direction);
            Console.ReadKey();
            //    return direction;

            return rover;
        }

        public static Vector Left(Vector rover)
        {
            Vector left = Vector.Left(rover);
            Direct(left);
            return left;
        }

        public static Vector Right(Vector rover)
        {

          Vector right = Vector.Right(rover);
            Direct(right);
            return right;
        }
    }
}
