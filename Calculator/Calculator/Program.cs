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
                Console.WriteLine("1  Basic Calculator (+ - * / % ! ^)\n2  Task 2\n3  Task 3\n4  Task 4\n0  Exit Menu System\n");
                string temp = Console.ReadLine();
                task = Convert.ToInt32(temp);
                Console.Clear();

                switch (task)
                {
                    case 1:
                        BasicCalc();
                        break;
                    //case 2:
                    //    Two();
                    //    break;
                    //case 3:
                    //    Three();
                    //    break;
                    //case 4:
                    //    Four();
                    //    break;
                }
            } while (task != 0 && task <= 4);
        }

        public static void BasicCalc()
        {
            Console.WriteLine("Calculator: ");
            string input = Console.ReadLine();
            string op = "";
            double result;
            if (input.Contains("!"))
            {
                op = "!";
            }
            else if (input.Contains("+"))
            {
                op = "+";
            }
            else if (input.Contains("-"))
            {
                op = "-";
            }
            else if (input.Contains("*"))
            {
                op = "*";
            }
            else if (input.Contains("/"))
            {
                op = "/";
            }
            else if (input.Contains("%"))
            {
                op = "%";
            }
            else if (input.Contains("^"))
            {
                op = "^";
            }
            //Squares and square roots
            else
            {
                Console.WriteLine("Invalid operator.");
                return;
            }
            if (op == "!")//Have to do ! before the split, as there is no num2 needed.
            {
                double numm1 = Convert.ToDouble(input.Replace("!", ""));
                result = 1;
                for (int i = 1; i <= numm1; i++)
                {
                    result *= i;
                }
                Console.Write($"= {result}");
                Console.WriteLine("\nPress enter to continue.");
                Console.ReadLine();
                return;
            }
            string[] numbers = input.Split(op[0]);
            double num1 = Convert.ToDouble(numbers[0]);
            double num2 = Convert.ToDouble(numbers[1]);
            if (op == "+")
            {
                result = num1 + num2;
                Console.Write($"= {result}");
            }
            else if (op == "-")
            {
                result = num1 - num2;
                Console.Write($"= {result}");
            }
            else if (op == "*")
            {
                result = num1 * num2;
                Console.Write($"= {result}");
            }
            else if (op == "/")
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
            else if (op == "%")
            {
                result = num1 % num2;
                Console.Write($"= {result}");
            }
            //else if (op == "^")
            //{
            //    result = num1 ^ num2;
            //    Console.WriteLine($"Answer: {result}");
            //}

            Console.WriteLine("\nPress enter to continue.");
            Console.ReadLine();
        }
    }
}
