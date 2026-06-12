using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int task;
            do
            {
                Console.Clear();
                Console.WriteLine("Main Menu\nPlease select from the numbers below");
                Console.WriteLine("1  Basic Calculator (+ - * / % ! ^ sqrt)\n2  Binary\n3  Matrices\n4  Geometry and Vectors\n5. Number Theory and Encryption\n6. Cryptography\n0  Exit Menu System\n");
                string temp = Console.ReadLine();
                task = Convert.ToInt32(temp);
                Console.Clear();

                switch (task)
                {
                    case 1:
                        BasicCalc();
                        break;
                    case 2:
                        Binary();
                        break;
                    case 3:
                        Matrices();
                        break;
                    case 4:
                        GandV();
                        break;
                    case 5:
                        NumTheandEncryp();
                        break;
                    case 6:
                        Cryptography();
                        break;
                }
            } while (task != 0 && task <= 6);//Lab 18 menu from Programming 1
        }

        public static void BasicCalc()//basic calc
        {
            Console.WriteLine("Calculator: ");
            string input = Console.ReadLine();
            string op = "";
            double result;
            if (input.Contains("!"))//Factorial
            {
                op = "!";
            }
            else if (input.Contains("+"))//Plus
            {
                op = "+";
            }
            else if (input.Contains("-"))//Minus
            {
                op = "-";
            }
            else if (input.Contains("*"))//Times
            {
                op = "*";
            }
            else if (input.Contains("/"))//Divide
            {
                op = "/";
            }
            else if (input.Contains("%"))//Mod
            {
                op = "%";
            }
            else if (input.Contains("^"))//To the power
            {
                op = "^";
            }
            else if (input.Contains("sqrt"))//Square root
            {
                op = "sqrt";
            }
            else
            {
                Console.WriteLine("\nInvalid operator.");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                return;
            }
            if (op == "!")//Have to do ! before the split, as there is no num2 needed. //Factorial
            {
                double numm1 = Convert.ToDouble(input.Replace("!", ""));
                result = 1;
                if (numm1 < 0)
                {
                    Console.WriteLine("\nFactorial cannot be negative.");
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                    return;
                }
                for (int i = 1; i <= numm1; i++)
                {
                    result *= i;
                }
                Console.Write($"= {result}");
                Console.WriteLine("\nPress enter to continue.");
                Console.ReadLine();
                return;
            }
            else if (op == "sqrt")//sqrt only requires one number as well.
            {
                double numm1 = Convert.ToDouble(input.Replace("sqrt", ""));
                double sqrt = Math.Sqrt(numm1);
                Console.Write($"= {sqrt}");
                Console.WriteLine("\nPress enter to continue.");
                Console.ReadLine();
                return;
            }

            string[] numbers = input.Split(op[0]);//splits at op
            double num1 = Convert.ToDouble(numbers[0]);//first num
            double num2 = Convert.ToDouble(numbers[1]);//second num
            if (op == "+")//Plus
            {
                result = num1 + num2;
                Console.Write($"= {result}");
            }
            else if (op == "-")//Minus
            {
                result = num1 - num2;
                Console.Write($"= {result}");
            }
            else if (op == "*")//Times
            {
                result = num1 * num2;
                Console.Write($"= {result}");
            }
            else if (op == "/")//Divide
            {
                if (num2 == 0)
                {
                    Console.WriteLine("\nCannot divide by zero.");
                    Console.ReadLine();
                    return;
                }
                result = num1 / num2;
                Console.Write($"= {result}");
            }
            else if (op == "%")//Mod
            {
                result = num1 % num2;
                Console.Write($"= {result}");
            }
            else if (op == "^")//To the power
            {
                result = 1;
                for (int i = 0; i < num2; i++)
                {
                    result *= num1;
                }
                Console.WriteLine($"Answer: {result}");
            }
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadLine();
            return;
        }

        public static void Binary()//The binary calculator
        {
            Console.WriteLine("Binary Calculator: ");
            Console.WriteLine("1. Decimal to Binary\n2. Binary Addition and Subtraction\n3. Hex Binary and Decimal conversion");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("\nCalculator: ");
                string input = Console.ReadLine();
                double num = Convert.ToDouble(input);
                string binary = "";
                if (num == 0)
                {
                    binary = "0";
                }
                else
                {
                    while (num > 0)
                    {
                        binary = (num % 2) + binary;
                        num /= 2;
                    }
                }
                while (binary.Length < 8)//Adds 0s so the binary is always 8 bits long
                {
                    binary = "0" + binary;
                }
                Console.WriteLine($"Binary: {binary}");
            }
            else if (choice == "2")
            {
                Console.WriteLine("\nCalculator: ");
                string input = Console.ReadLine();
                string op = "";
                if (input.Contains("+"))//Plus
                {
                    op = "+";
                }
                else if (input.Contains("-"))//Minus
                {
                    op = "-";
                }
                else
                {
                    Console.WriteLine("\nInvalid operator.");
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                    return;
                }
                string[] numbers = input.Split(op[0]);
                int num1 = Convert.ToInt32(numbers[0], 2);
                int num2 = Convert.ToInt32(numbers[1], 2);
                int num3 = 0;
                if (op == "+")//Plus
                {
                    num3 = num1 + num2;
                }
                else if (op == "-")//Minus
                {
                    num3 = num1 - num2;
                }
                string binary = Convert.ToString(num3, 2);
                while (binary.Length < 8)//Adds 0s so the binary is always 8 bits long
                {
                    binary = "0" + binary;
                }
                Console.WriteLine($"= {binary}");
                Console.WriteLine("\nPress enter to continue.");
                Console.ReadLine();
                return;
            }
            //else if (choice == "3")
            //{
            //    Console.WriteLine("Binary Calculator: ");
            //    Console.WriteLine("1. Decimal to Binary/Hex\n2. Binary to Decimal/Hex\n3. Hex to Decimal/Binary");
            //    Console.WriteLine("\nCalculator: ");
            //    string choice2 = Console.ReadLine();
            //    if (choice2 == "1")
            //    {

            //    }
            //    else if (choice2 == "2")
            //    {

            //    }
            //    else if (choice2 == "3")
            //    {

            //    }
            //}
            else
            {
                Console.WriteLine("\nInvalid option");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadLine();
            return;
        }
        public static void Matrices()
        {
            Console.WriteLine("Matrices Calculator: ");
            Console.WriteLine("1. Addition\n2. Subtraction\n3. Dot Product\n4. Scalar\n5. Determinant");
            string choice = Console.ReadLine();
            Console.WriteLine("\na: b: c: d:");
            string input1 = Console.ReadLine();
            string[] numbers1 = input1.Split(" ");
            double a = Convert.ToDouble(numbers1[0]);
            double b = Convert.ToDouble(numbers1[1]);
            double c = Convert.ToDouble(numbers1[2]);
            double d = Convert.ToDouble(numbers1[3]);

            if (choice == "1")
            {
                Console.WriteLine("\ne: f: g: h:");
                string input2 = Console.ReadLine();
                string[] numbers2 = input2.Split(" ");
                double e = Convert.ToDouble(numbers2[0]);
                double f = Convert.ToDouble(numbers2[1]);
                double g = Convert.ToDouble(numbers2[2]);
                double h = Convert.ToDouble(numbers2[3]);

                double num1 = a + e;
                double num2 = b + f;
                double num3 = c + g;
                double num4 = d + h;
                Console.WriteLine($"\n{num1} {num2}");
                Console.WriteLine($"{num3} {num4}");
            }
            else if (choice == "2")
            {
                Console.WriteLine("\ne: f: g: h:");
                string input2 = Console.ReadLine();
                string[] numbers2 = input2.Split(" ");
                double e = Convert.ToDouble(numbers2[0]);
                double f = Convert.ToDouble(numbers2[1]);
                double g = Convert.ToDouble(numbers2[2]);
                double h = Convert.ToDouble(numbers2[3]);

                double num1 = a - e;
                double num2 = b - f;
                double num3 = c - g;
                double num4 = d - h;
                Console.WriteLine($"\n{num1} {num2}");
                Console.WriteLine($"{num3} {num4}");
            }
            else if (choice == "3")
            {
                Console.WriteLine("\ne: f: g: h:");
                string input2 = Console.ReadLine();
                string[] numbers2 = input2.Split(" ");
                double e = Convert.ToDouble(numbers2[0]);
                double f = Convert.ToDouble(numbers2[1]);
                double g = Convert.ToDouble(numbers2[2]);
                double h = Convert.ToDouble(numbers2[3]);
                //split all these longer ones so its easier to read.
                double num1 = (a * e) + (b * g);
                double num2 = (a * f) + (b * h);
                double num3 = (c * e) + (d * g);
                double num4 = (c * f) + (d * h);
                Console.WriteLine($"\n{num1} {num2}");
                Console.WriteLine($"{num3} {num4}");
            }
            else if (choice == "4")
            {
                Console.WriteLine("Enter scalar:");
                double scalar = Convert.ToDouble(Console.ReadLine());
                double num1 = a * scalar;
                double num2 = b * scalar;
                double num3 = c * scalar;
                double num4 = d * scalar;

                Console.WriteLine($"\n{num1} {num2}");
                Console.WriteLine($"{num3} {num4}");
            }
            else if (choice == "5")
            {
                double determinant = (a * d) - (b * c);
                Console.WriteLine($"= {determinant}");
            }
            else
            {
                Console.WriteLine("\nInvalid option");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadLine();
            return;
        }

        public static void GandV()
        {
            Console.WriteLine("Matrices Calculator: ");
            Console.WriteLine("1. Distance between two points\n2. Midpoint between two points\n3. Gradient");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("\nx1: y1:");
                string input1 = Console.ReadLine();
                string[] numbers1 = input1.Split(" ");
                double x1 = Convert.ToDouble(numbers1[0]);
                double y1 = Convert.ToDouble(numbers1[1]);

                Console.WriteLine("\nx2: y2:");
                string input2 = Console.ReadLine();
                string[] numbers2 = input2.Split(" ");
                double x2 = Convert.ToDouble(numbers2[0]);
                double y2 = Convert.ToDouble(numbers2[1]);

                double x = (x2 - x1);
                double y = (y2 - y1);
                double total = (x * x) + (y * y);

                double sqrt = Math.Sqrt(total);

                Console.WriteLine($"= {sqrt}");

            }
            else if (choice == "2")
            {
                Console.WriteLine("\nx1: y1:");
                string input1 = Console.ReadLine();
                string[] numbers1 = input1.Split(" ");
                double x1 = Convert.ToDouble(numbers1[0]);
                double y1 = Convert.ToDouble(numbers1[1]);

                Console.WriteLine("\nx2: y2:");
                string input2 = Console.ReadLine();
                string[] numbers2 = input2.Split(" ");
                double x2 = Convert.ToDouble(numbers2[0]);
                double y2 = Convert.ToDouble(numbers2[1]);

                double x = (x1 + x2) / 2;
                double y = (y1 + y2) / 2;

                Console.WriteLine($"= {x},{y}");
            }
            else if (choice == "3")
            {
                Console.WriteLine("\nx1: y1:");
                string input1 = Console.ReadLine();
                string[] numbers1 = input1.Split(" ");
                double x1 = Convert.ToDouble(numbers1[0]);
                double y1 = Convert.ToDouble(numbers1[1]);
                //split all these longer ones so its easier to read. was helping with testing if things work
                Console.WriteLine("\nx2: y2:");
                string input2 = Console.ReadLine();
                string[] numbers2 = input2.Split(" ");
                double x2 = Convert.ToDouble(numbers2[0]);
                double y2 = Convert.ToDouble(numbers2[1]);

                double a = (y2 - y1);
                double b = (x2 - x1);
                double grad = a / b;

                Console.WriteLine($"= {grad}");
            }
            else
            {
                Console.WriteLine("\nInvalid option");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadLine();
            return;
        }

        public static void NumTheandEncryp()
        {
            Console.WriteLine("Number Theory and Encryption: ");
            Console.WriteLine("1. Primality");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Write("Number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 2)
                {
                    Console.WriteLine("Not a prime number");
                }
                else
                {
                    int prime = 0;
                    double sqrt = Math.Sqrt(num);
                    for (int i = 2; i <= sqrt; i++)//eg. sqrt49 = 7. 
                    {
                        double test = (double)num / i;//49 / 2....49 / 7
                        if (test == Convert.ToInt32(test))
                        {
                            prime++;
                        }
                    }
                    if (prime == 0)//If prime stays at 0, it means no whole numbers were found
                    {
                        Console.WriteLine("Prime number");
                    }
                    else //if prime goes up at all, there was a whole number found, so its not a prime number
                    {
                        Console.WriteLine("Not a prime number");
                    }
                }
            }
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadLine();
            return;
        }

        public static void Cryptography()
        {
            Console.WriteLine("N/A");
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadLine();
            return;
        }
    }
}
