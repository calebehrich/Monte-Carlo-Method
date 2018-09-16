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
               
                    Console.WriteLine("How many points would you like to check?");                 
                    numberOfCords = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");

              
                    Coordinate[] coordinates = new Coordinate[numberOfCords];
                    for (int i = 0; i < coordinates.Length; i++)
                    {
                         coordinates[i] = new Coordinate(Rnd);
                    }
                    for (int i = 0; i < coordinates.Length; i++)
                    {
                        if (Hypotenuse(coordinates[i]) <= 1)
                        {
                            points++;
                        }
                    }

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
