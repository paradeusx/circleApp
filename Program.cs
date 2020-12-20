using System;

namespace circleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //vars
            const double pi = Math.PI;
            double area = 0, circumference = 0, radius = 0, diameter = 0, areaU = 0, circumferenceU = 0, radiusU, diameterU;
            string userAnswer, units = "cm", statement = "The {0} of the circle is {1}{2}",
                statement2 = "Would you like the non-rounded version? y/n", userAnswer2 = "",
                reply = "{0}{1} is the answer non-rounded", thankYou = "Thank you for using paradox#4005's circleApp!",
                areaM = "area", radiusM = "radius", circumferenceM = "circumference", diameterM = "diameter", errorM = "Please specify a correct answer";


            Console.WriteLine("Welcome to the circle app!\nThis app is used to calculate measurements for circles");
            Console.WriteLine("What would you like to calculate (Area, Radius, Circumference, Diameter)");

            userAnswer = Console.ReadLine();

            if (userAnswer == "area") // A = pi r^2; AREA SCENARIO
            {
                Console.WriteLine("Enter the radius of the circle: ");
                radius = Double.Parse(Console.ReadLine());
                area = (radius * radius) * pi;
                areaU = area;
                area = Math.Round(area);
                Console.WriteLine(statement, areaM, area, units);
                Console.WriteLine(statement2);
                userAnswer2 = Console.ReadLine();
                if (userAnswer2 == "yes" || userAnswer2 == "y")
                {
                    Console.WriteLine(reply, areaU, units);
                    Console.WriteLine(thankYou);

                } else
                {
                    Console.WriteLine(thankYou);
                }
            }
            else if (userAnswer == "circumference") // C = 2pir or pi d; CIRCUMFERENCE SCENARIO
            {
                Console.WriteLine("Would you like to enter diameter or radius (r/d)");
                userAnswer2 = Console.ReadLine();
                if (userAnswer2 == "r")
                {
                    Console.WriteLine("Enter radius: ");
                    radius = Double.Parse(Console.ReadLine());
                    circumference = 2 * pi * radius;
                    circumferenceU = circumference;
                    circumference = Math.Round(circumference);
                    Console.WriteLine(statement, circumferenceM, circumference, units);
                    Console.WriteLine(statement2);
                    userAnswer2 = Console.ReadLine();
                    if (userAnswer2 == "yes" || userAnswer2 == "y")
                    {
                        Console.WriteLine(reply, circumferenceU, units);
                        Console.WriteLine(thankYou);

                    }
                    else
                    {
                        Console.WriteLine(thankYou);
                    }

                } else if (userAnswer2 == "d")
                {
                    Console.WriteLine("Enter diameter: ");
                    diameter = Double.Parse(Console.ReadLine());
                    circumference = pi * diameter;
                    circumferenceU = circumference;
                    circumference = Math.Round(circumference);
                    Console.WriteLine(statement, circumferenceM, circumference, units);
                    Console.WriteLine(statement2);
                    userAnswer2 = Console.ReadLine();
                    if (userAnswer2 == "yes" || userAnswer2 == "y")
                    {
                        Console.WriteLine(reply, circumferenceU, units);
                        Console.WriteLine(thankYou);
                    }
                    else
                    {
                        Console.WriteLine(thankYou);
                    }

                }
                else
                {
                    Console.WriteLine(errorM);
                }
                

            } else if (userAnswer == "radius") // R = C / (PI x 2) || d/2 RADIUS SCENARIO
            {
                Console.WriteLine("Would you like to calculate it from {0} or {1} (d/c)", diameterM, circumferenceM);
                userAnswer2 = Console.ReadLine();
                if (userAnswer2 == "d")
                {
                    Console.WriteLine("Enter {0}: ", diameterM);
                    diameter = Double.Parse(Console.ReadLine());
                    radius = diameter / 2;
                    radiusU = radius;
                    radius = Math.Round(radius);
                    Console.WriteLine(statement, radiusM, radius, units);
                    Console.WriteLine(statement2);
                    userAnswer2 = Console.ReadLine();
                    if (userAnswer2 == "yes" || userAnswer2 == "y")
                    {
                        Console.WriteLine(reply, radiusU, units);
                        Console.WriteLine(thankYou);

                    } else
                    {
                        Console.WriteLine(thankYou);
                    }

                } else if (userAnswer2 == "c")
                {
                    Console.WriteLine("Enter {0}: ", circumferenceM);
                    circumference = Double.Parse(Console.ReadLine());
                    radius = circumference / (pi * 2);
                    radiusU = radius;
                    radius = Math.Round(radius);
                    Console.WriteLine(statement, radiusM, radius, units);
                    Console.WriteLine(statement2);
                    userAnswer2 = Console.ReadLine();
                    if (userAnswer2 == "yes" || userAnswer2 == "y")
                    {
                        Console.WriteLine(reply, radiusU, units);
                        Console.WriteLine(thankYou);

                    } else
                    {
                        Console.WriteLine(thankYou);
                    }

                } else
                {
                    Console.WriteLine(errorM);
                }
            } else if (userAnswer == "diameter") // D = 2r;  DIAMETER SCENARIO
            {
                Console.WriteLine("Enter {0}: ", radiusM);
                radius = Double.Parse(Console.ReadLine());
                diameter = radius * 2;
                diameterU = diameter;
                diameter = Math.Round(diameter);
                Console.WriteLine(statement, diameterM, diameter, units);
                Console.WriteLine(statement2);
                userAnswer2 = Console.ReadLine();
                if (userAnswer2 == "yes" || userAnswer2 == "y")
                {
                    Console.WriteLine(reply, diameterU, units);
                    Console.WriteLine(thankYou);

                }
                else
                {
                    Console.WriteLine(thankYou);
                }

            } else
            {
                Console.WriteLine(errorM);
            }


        }
    }
}
