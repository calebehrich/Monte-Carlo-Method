using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{

    struct Coordinate
    {
        public double xcord;
        public double ycord;


        public Coordinate(Random Rnd)
        {
            this.xcord = Rnd.NextDouble();
            this.ycord = Rnd.NextDouble();
        }
       
    }

    class Program
    {
        public static double Hypotenuse(Coordinate point)
        {
            double hypotenuse = Math.Sqrt((Math.Pow(point.xcord, 2) + Math.Pow(point.ycord, 2)));
            return hypotenuse;
        }


        static void Main(string[] args)
        {
            int numberOfCords = 0;
            Random Rnd = new Random();
           

            do
            {
                double points = 0.0;
                    //Collects number of points user wants in the array
                    Console.WriteLine("How many points would you like to check?");                 
                    numberOfCords = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");


                    //Takes user input to create an array of that size and gives them a random value
                    Coordinate[] coordinates = new Coordinate[numberOfCords];
                    for (int i = 0; i < coordinates.Length; i++)
                    {
                         coordinates[i] = new Coordinate(Rnd);
                    }
                    //iterates through the array and plugs random values into the hypotenuse equation
                    for (int i = 0; i < coordinates.Length; i++)
                    {
                        if (Hypotenuse(coordinates[i]) <= 1)
                        {
                            points++;
                        }
                    }
                    //displays difference between monte carlo simulation and actual value of Pi
                    double overlap = points / coordinates.Length;
                    overlap *= 4;
                    Console.WriteLine($"{overlap}");
                    Console.WriteLine(Math.PI); 
                    Console.WriteLine($"The difference is: {Math.Abs(overlap - Math.PI)}");
                
                Console.ReadLine();
            } while (numberOfCords != 0);
            


        }

      
    }
}
