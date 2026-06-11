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
                Console.WriteLine("1  Basic Calculator (+ - * / % ! ^ SQRT)\n2  Binary\n3  Matrices\n4  Task 4\n0  Exit Menu System\n");
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
                        //    break;
                        //case 4:
                        //    Four();
                        //    break;
                }
            } while (task != 0 && task <= 4);//Lab 18 menu from Programming 1
        }

        public static void BasicCalc()
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
                int numm1 = Convert.ToInt32(input.Replace("!", ""));
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
            //else if (op == "sqrt")
            //{
            //    double numm1 = Convert.ToDouble(input.Replace("sqrt", ""));
            //}
            string[] numbers = input.Split(op[0]);
            double num1 = Convert.ToDouble(numbers[0]);
            double num2 = Convert.ToDouble(numbers[1]);
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

        public static void Binary()
        {
            Console.WriteLine("Binary Calculator: ");
            Console.WriteLine("1. Decimal to Binary\n2. Binary Addition and Subtraction\n3. Hex Binary and Decimal conversion");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("\nCalculator: ");
                string input = Console.ReadLine();
                int num = Convert.ToInt32(input);
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
            int a = Convert.ToInt32(numbers1[0]);
            int b = Convert.ToInt32(numbers1[1]);
            int c = Convert.ToInt32(numbers1[2]);
            int d = Convert.ToInt32(numbers1[3]);


            if (choice == "1")
            {
                Console.WriteLine("\ne: f: g: h:");
                string input2 = Console.ReadLine();
                string[] numbers2 = input2.Split(" ");
                int e = Convert.ToInt32(numbers2[0]);
                int f = Convert.ToInt32(numbers2[1]);
                int g = Convert.ToInt32(numbers2[2]);
                int h = Convert.ToInt32(numbers2[3]);
                int num1 = a + e;
                int num2 = b + f;
                int num3 = c + g;
                int num4 = d + h;
                Console.WriteLine($"\n{num1} {num2}");
                Console.WriteLine($"{num3} {num4}");
            }
            else if (choice == "2")
            {
                Console.WriteLine("\ne: f: g: h:");
                string input2 = Console.ReadLine();
                string[] numbers2 = input2.Split(" ");
                int e = Convert.ToInt32(numbers2[0]);
                int f = Convert.ToInt32(numbers2[1]);
                int g = Convert.ToInt32(numbers2[2]);
                int h = Convert.ToInt32(numbers2[3]);
                int num1 = a - e;
                int num2 = b - f;
                int num3 = c - g;
                int num4 = d - h;
                Console.WriteLine($"\n{num1} {num2}");
                Console.WriteLine($"{num3} {num4}");
            }
            else if (choice == "3")
            {
                Console.WriteLine("\ne: f: g: h:");
                string input2 = Console.ReadLine();
                string[] numbers2 = input2.Split(" ");
                int e = Convert.ToInt32(numbers2[0]);
                int f = Convert.ToInt32(numbers2[1]);
                int g = Convert.ToInt32(numbers2[2]);
                int h = Convert.ToInt32(numbers2[3]);
                int num1 = (a * e) + (b * g);
                int num2 = (a * f) + (b * h);
                int num3 = (c * e) + (d * g);
                int num4 = (c * f) + (d * h);
                Console.WriteLine($"\n{num1} {num2}");
                Console.WriteLine($"{num3} {num4}");
            }
            else if (choice == "4")
            {
                Console.WriteLine("Enter scalar:");
                int scalar = Convert.ToInt32(Console.ReadLine());
                int num1 = a * scalar;
                int num2 = b * scalar;
                int num3 = c * scalar;
                int num4 = d * scalar;
                Console.WriteLine($"\n{num1} {num2}");
                Console.WriteLine($"{num3} {num4}");
            }
            else if (choice == "5")
            {
                int determinant = (a * d) - (b * c);
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
    }
}
