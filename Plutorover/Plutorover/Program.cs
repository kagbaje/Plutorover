using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Plutorover
{

   public class Program

    {



        public static void Main(string[] args)
        {


            Vector run = new Vector(0,2);
            Left(run);
            Right(run);


        }
           
    
        /*
         * @param Vector of rover
         * returns direction of Rover (N,W,E,S)
         */ 
        public static string Direction(Vector rover)
        {
            string direction;

            Vector north = new Vector(0, 100);

            Vector east = new Vector(100, 0);

            Vector west = new Vector(-100, 0);

            Vector south = new Vector(0, -100);


            if (Vector.AngleBetween(rover, north) == 0)
            {
                direction = "N";
                Console.WriteLine("direction = {0}", direction);
                Console.ReadKey();
                return direction;

            }
            else if (Vector.AngleBetween(rover, south) == 0)
            {
                direction = "S";
                Console.WriteLine("direction = {0}", direction);
                Console.ReadKey();
                return direction;

            }
            else if (Vector.AngleBetween(rover, east) == 0)
            {
                direction = "E";
                Console.WriteLine("direction = {0}", direction);
                Console.ReadKey();
                return direction;
            }
            else if (Vector.AngleBetween(rover, west) == 0)
            {
                direction = "W";
                Console.WriteLine("direction = {0}", direction);
                Console.ReadKey();
                return direction;
            }
            else
            {
                Console.WriteLine("idk where i'm going");
                Console.ReadKey();
                direction = "null";
                return direction;

            }
   

        }

        /*
         * @param Vector of rover
         * Returns new forward direction of rover based on direction
         * includes world bounds
         */ 

        public static Vector Forward(Vector rover)
        {

            int posgrid = 100;
            int neggrid = -100;
            bool isObject =  Collision(rover);
          
            string direction = Direction(rover);
           
            if (!isObject)
            {

                if (direction == "N")
                {
                   
                    if (rover.y == posgrid)
                    {
                        rover.y = -99;
                    }
                    else
                    {
                        rover.y++;
                    }
                   
                }
                else if (direction == "E")
                {
                    
                    if (rover.x == posgrid)
                    {
                        rover.x = -99;
                    }
                    else
                    {
                        rover.x++;
                    }
                   
                }
                else if (direction == "W")
                {
                   
                    if (rover.x == neggrid)
                    {
                        rover.x = 99;
                    }
                    else
                    {
                        rover.x--;
                    }
                   
                }
                else if (direction == "S")
                {
                   
                    if (rover.y == neggrid)
                    {
                        rover.y = 99;
                    }
                    else
                    {
                        rover.y--;
                    }
                  
                }

               
                return rover;
            }
            else
            {
                Console.WriteLine("didnt move forward");
                Console.ReadKey();
            }
        

            return rover;
        }

        /*
         * @param Vector of rover
         * Returns new backward direction of rover based on direction
         * includes world bounds
         */
 
        public static Vector Backward(Vector rover)
        {

            int posgrid = 100;
            int neggrid = -100;
            bool isObject = Collision(rover);
            string direction = Direction(rover);
          

            if ( isObject == false) {
                

                if (direction == "N")
                {
                   
                    if (rover.y == neggrid)
                    {
                        rover.y = 99;
                    }
                    else
                    {
                        rover.y--;
                    }
                   
                }
                else if (direction == "E")
                {
                
                    if (rover.x == neggrid)
                    {
                        rover.x = 99;
                    }
                    else
                    {
                        rover.x--;
                    }

                }
                else if (direction == "W")
                {
                    
                    if (rover.x == posgrid)
                    {
                        rover.x = -99;
                    }
                    else
                    {
                        rover.x++; ;
                    }


                }
                else if (direction =="S")
                {
                    if (rover.y == posgrid)
                    {
                        rover.y = -99;
                    }
                    else
                    {
                        rover.y++;
                    }

                  
                }

            }

            return rover;
        }

        /*
         * @param Vector of rover
         * Rotates rover at 90 degrees anticlockwise
         * 
         */


        public static Vector Left(Vector rover)
        {
            Vector left = Vector.Left(rover);
           
            left.x = rover.x;
            left.y = rover.y;
            
            return left;
        }



        /*
         * @param Vector of rover
         * Rotates rover at 90 degrees clockwise
         *
         * 
         */
 
        public static Vector Right(Vector rover)
        {

          Vector right = Vector.Right(rover);
          
          right.x = rover.x;
           right.y = rover.y;
          

            return right;
        }


        /*
         * @param Vector of rover
         * bool that returns based on if vector of rover and obstacle are equal
         * 
         * 
         */




        public static bool Collision(Vector rover)
        {
            Vector obstacle = new Vector(2,2);
            bool isObject;

            if (rover.x == obstacle.x && rover.y == obstacle.y)
            {
                isObject = true;
                
                
               
                
            }
            else
            {
                isObject = false;
              
            }
          
            
            return isObject;

        }
    }

}
