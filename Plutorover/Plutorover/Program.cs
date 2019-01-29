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

        Position.Vector north = new Position.Vector(0, 100);
      
        Vector east = new Vector(100, 0);
        
        Vector west = new Vector(-100, 0);
       
        Vector south = new Vector(0, -100);

        Vector obstruction = new Vector(1, 0);

       Vector obstruction1 = new Vector(1, 1);




        static void Main(string[] args)
        {
            Vector rover = new Vector(0, 0);
            obstruct(rover);
        
         
         
        

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

        public static string Obstruct(Vector rover)
        {
            Vector obstruction = new Vector(5, 6);
            string message;


            if (obstruction.x == rover.x && obstruction.y == rover.y)
            {
                message = "There is an obstruction";
                Console.WriteLine("message:{0}", message);
                Console.ReadKey();
            }
            else
            {
                message = "No obstruction carry on";
                Console.WriteLine("message:{0}", message);
                Console.ReadKey();
            }


            return message;
        }


            public void World (Vector rover)
            {
                Vector Posworld = new Vector(100, 100);
                Vector Negworld = new Vector(-100, -100);
            if (rover.x > 100)   
            {
                rover.x = -99;
            }
            else if(rover.y > 100){
                rover.y = -99;

            }
            else if (rover.x < -100) { 
            rover.x = 100;
             }
            else if (rover.y < -100)
            {
                rover.y = 100;
            }
              
            }

    }

}
