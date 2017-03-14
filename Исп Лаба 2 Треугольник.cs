using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Please enter the first side of the triangle:\n ");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second side of the triangle: \n");
            double second = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third side of the triangle: \n");
            double third = double.Parse(Console.ReadLine());
            double power = 2.0;
            {
                if (first <= 0)
                    Console.WriteLine("Go away\n ");
                else if (second <= 0)
                    Console.WriteLine(" Are not you ashamed? \n ");
                else if (third <= 0)
                    Console.WriteLine("You crazy!\n ");
                else
                {
                    if (first + second < third)
                        Console.WriteLine("It's disgusting! Try again.\n ");
                    else if (first + third < second)
                        Console.WriteLine("Um .. What? Try again.\n ");
                    else if (second + third < first)
                        Console.WriteLine("You do not mistake? Exactly? Try again.\n ");
                    else






                        Console.Write("\n The first angle = ");
                    double cosinus1 = (Math.Pow(third, power) + Math.Pow(second, power) - Math.Pow(first, power)) / (2 * third * second);
                    double angle1 = (Math.Acos(cosinus1) * 180) / Math.PI;
                    Console.Write(angle1);


                    Console.Write("\n The second angle = ");
                    double cosinus2 = (Math.Pow(third, power) + Math.Pow(first, power) - Math.Pow(second, power)) / (2 * third * first);
                    double angle2 = (Math.Acos(cosinus2) * 180) / Math.PI;
                    Console.Write(angle2);

                    Console.Write("\n The third angle = ");
                    double cosinus3 = (Math.Pow(second, power) + Math.Pow(first, power) - Math.Pow(third, power)) / (2 * second * first);
                    double angle3 = (Math.Acos(cosinus3) * 180) / Math.PI;

                    Console.Write(angle3);


                    Console.Write("\n Perimeter = ");
                    double perimeter = first + second + third;
                    Console.Write(perimeter);

                    Console.Write("\n Poluperimeter = ");
                    double poluperimeter = perimeter / 2;
                    Console.Write(poluperimeter);

                    Console.Write("\n Area = ");
                    double area = Math.Sqrt(poluperimeter * (poluperimeter - first) * (poluperimeter - second) * (poluperimeter - third));
                    Console.Write(area);

                    Console.Write("\n The radius of the inscribed circle = ");
                    double vpisan = area / poluperimeter;
                    Console.Write(vpisan);

                    Console.Write("\n The radius of the circumscribed circle = ");
                    double opisan = (first * second * third) / (4 * area);
                    Console.Write(opisan);
                }
            }
            Console.ReadLine();
        }
    }
}