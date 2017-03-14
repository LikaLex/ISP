using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Choose what you want to find( Current(I)- 1 , Resistance(R) - 2,Voltage(U) - 3): ");
            int number = int.Parse(Console.ReadLine());
            //current-сила тока , resistance - сопротивление ,voltage - напряжение 
            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("Input voltage: ");
                        float voltage = float.Parse(Console.ReadLine());
                        Console.WriteLine("Input resistance: ");
                        float resistance = float.Parse(Console.ReadLine());
                        if (resistance <= 0)
                        {
                            Console.WriteLine("You enter error resistance!");
                            Console.ReadLine();
                            return 0;
                        }
                        else if (voltage <= 0)
                        {
                            Console.WriteLine("You enter error voltage!");
                            Console.ReadLine();
                            return 0;
                        }
                        else
                        {
                            Console.Write("current = ");
                            Console.Write(voltage / resistance);
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Input voltage: ");
                        float voltage = float.Parse(Console.ReadLine());
                        Console.WriteLine("Input current: ");
                        float current = float.Parse(Console.ReadLine());
                        if (current <= 0)
                        {
                            Console.WriteLine("You enter error current");
                            Console.ReadLine();
                            return 0;
                        }
                        else if (voltage <= 0)
                        {
                            Console.WriteLine("You enter error voltage!");
                            Console.ReadLine();
                            return 0;
                        }
                        else
                        {
                            Console.Write("resistance = ");
                            Console.Write(voltage / current);
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Input resistance: ");
                        float resistance = float.Parse(Console.ReadLine());
                        Console.WriteLine("Input current: ");
                        float current = float.Parse(Console.ReadLine());
                        if (current <= 0)
                        {
                            Console.WriteLine("You enter error current");
                            Console.ReadLine();
                            return 0;
                        }
                        else if (resistance <= 0)
                        {
                            Console.WriteLine("You enter error resistance!");
                            Console.ReadLine();
                            return 0;
                        }
                        else
                            Console.Write("voltage = ");
                        Console.Write(resistance * current);
                        break;
                    }
                default:
                    Console.WriteLine("You enter the wrong line!"); break;
            }
            Console.ReadLine();
            return 0;
        }
    }
}