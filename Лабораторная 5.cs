using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
{
    class Program
    {
        internal class MeasurementInfo
        {
            private readonly string[] _measures = { "Km/h", "Kg", "Kwt", "Sec" };
            public string[] Measures
            {
                get { return _measures; }
            }

            public string this[string index]
            {
                get
                {
                    if (index == "speed")
                        return _measures[0];
                    else if (index == "weight")
                        return _measures[1];
                    else if (index == "power")
                        return _measures[2];
                    else if (index == "time")
                        return _measures[3];
                    else
                        return null;
                }
            }
        }

        internal enum Color
        {
            Red,
            Green,
            Blue,
            Yellow,
            Gray,
            Black,
            White,
            Navi
        }

        internal class Transport
        {
            private static uint _numberOfObjects = 0;
            public static uint NumberOfObjects
            {
                get { return _numberOfObjects; }
            }

            // defining measurement system
            private MeasurementInfo _measurement;
            public MeasurementInfo Measurement
            {
                get { return _measurement; }
            }

            private uint _maxSpeed;
            public uint MaxSpeed
            {
                get { return _maxSpeed; }
            }

            private uint _weight;
            public uint Weight
            {
                get { return _weight; }
            }

            private uint _power;
            public uint Power
            {
                get { return _power; }
            }

            private double _timeTo100;
            public double TimeTo100
            {
                get { return _timeTo100; }
            }

            // trying to avoid inadequate new data 
            public bool Modify(uint new_max_speed, uint new_weight, uint new_power, double new_timeTo100)
            {
                if (new_timeTo100 <= 0)
                    return false;
                else if (new_power * new_timeTo100 <= 5 * new_weight / 3.6 / 3.6)
                    return false;
                else
                {
                    _maxSpeed = new_max_speed;
                    _weight = new_weight;
                    _power = new_power;
                    _timeTo100 = new_timeTo100;
                    return true;
                }
            }

            // functions to display our object
            public void Display()
            {
                Console.WriteLine(MaxSpeed.ToString() + " " + Measurement["speed"]);
                Console.WriteLine(Power.ToString() + " " + Measurement["power"]);
                Console.WriteLine(Weight.ToString() + " " + Measurement["weight"]);
                Console.WriteLine(TimeTo100.ToString() + " " + Measurement["time"]);
            }

            public void Display(string divider)
            {
                Console.WriteLine(MaxSpeed.ToString() + divider + Measurement["speed"]);
                Console.WriteLine(Power.ToString() + divider + Measurement["power"]);
                Console.WriteLine(Weight.ToString() + divider + Measurement["weight"]);
                Console.WriteLine(TimeTo100.ToString() + divider + Measurement["time"]);
            }

            // defining constructors
            public Transport()
            {
                _numberOfObjects++;
                _maxSpeed = 0;
                _weight = 0;
                _power = 0;
                _timeTo100 = 0;
            }

            public Transport(uint max_speed, uint weight, uint power, double timeTo100)
            {
                _numberOfObjects++;
                if (timeTo100 <= 0 || (power * timeTo100 <= 5 * weight / 3.6 / 3.6))
                {
                    _maxSpeed = 0;
                    _weight = 0;
                    _power = 0;
                    _timeTo100 = 0;
                }
                else
                {
                    _maxSpeed = max_speed;
                    _weight = weight;
                    _power = power;
                    _timeTo100 = timeTo100;
                }

                _measurement = new MeasurementInfo();
            }

            ~Transport()
            {
                _numberOfObjects--;
            }
        }

        internal abstract class Car : Transport
        {
            public abstract Color Color { get; }

            public abstract ulong Price { get; }

            public abstract bool SoldAlready { get; }

            public abstract bool Sell();

            public Car(uint max_speed, uint weight, uint power, double timeTo100) : base(max_speed, weight, power, timeTo100) {}
        }

        internal class FerrariEnzo : Car
        {
            private Color _color;
            public override Color Color
            {
                get { return _color; }
            }

            private ulong _price;
            public override ulong Price
            {
                get { return _price; }
            }

            private bool _sold;
            public override bool SoldAlready
            {
                get { return _sold; }
            }

            public override bool Sell()
            {
                Console.WriteLine("We have sold our Ferrari for " + _price.ToString() + " dollars;");
                _sold = true;
                return true;
            }

            public FerrariEnzo(Color FactoryColor) : base(350, 1255, 478, 3.3) 
            {
                _sold = false;
                _price = 650000;
                _color = FactoryColor;
            }
        }

        static void Main(string[] args)
        {
            // displaying our object
            Transport MyCar = new Transport(200, 1000, 200, 8);
            MyCar.Display();
            Transport[] MoreCars = { new Transport(250, 1200, 225, 7.4),
                                     new Transport(250, 1200, 225, 7.4), 
                                     new Transport(250, 1200, 225, 7.4), 
                                     new Transport(250, 1200, 225, 7.4) 
                                   };
            Console.WriteLine("We produced " + Transport.NumberOfObjects + " \"Transport\" objects");
            
            FerrariEnzo MyFerrari = new FerrariEnzo(Color.Red);
            FerrariEnzo[] MoreFerrari = { new FerrariEnzo(Color.Blue),
                                        new FerrariEnzo(Color.Yellow), 
                                        new FerrariEnzo(Color.Green), 
                                        new FerrariEnzo(Color.Navi) 
                                      };

            Console.WriteLine("We produced " + Transport.NumberOfObjects + " \"Transport\" objects and their descendants");
            Console.ReadKey(true);
            Console.WriteLine();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("The color of this Enzo Ferrari is " + MoreFerrari[i].Color.ToString());
                MoreFerrari[i].Sell();
            }
            Console.ReadKey(true);
        }
    }
}
