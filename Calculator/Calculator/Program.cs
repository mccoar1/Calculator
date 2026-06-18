using System;
using System.Security.Cryptography;

namespace Calculator
{
    internal class Program
    {
        public static void Main(string[] args)
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
            Console.WriteLine("1. Decimal to Binary\n2. Binary Addition and Subtraction\n3. Hex, Binary and Decimal conversion\n4. BCD");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("\nCalculator: ");
                int dec = Convert.ToInt32(Console.ReadLine());
                string binaryValue = Convert.ToString(dec, 2);              
                while (binaryValue.Length < 8)//Adds 0s so the binary is always 8 bits long
                {
                    binaryValue = "0" + binaryValue;
                }
                Console.WriteLine($"Binary: {binaryValue}");
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
                while (binary.Length < 8)
                {
                    binary = "0" + binary;
                }
                Console.WriteLine($"= {binary}");
                Console.WriteLine("\nPress enter to continue.");
                Console.ReadLine();
                return;
            }
            else if (choice == "3")
            {
                //Console.WriteLine("N/A");
                Console.WriteLine("Conversion Calculator: ");
                Console.WriteLine("1. Decimal to Binary/Hex\n2. Binary to Decimal/Hex\n3. Hex to Decimal/Binary");
                string choice2 = Console.ReadLine();
                if (choice2 == "1")
                {
                    Console.WriteLine("Decimal: ");//decimal conversion
                    int dec = Convert.ToInt32(Console.ReadLine());
                    string binaryValue = Convert.ToString(dec, 2);
                    string hexValue = dec.ToString("X");
                    while (binaryValue.Length < 8)
                    {
                        binaryValue = "0" + binaryValue;
                    }
                    Console.WriteLine($"Binary = {binaryValue}\nHex = {hexValue}");
                }
                else if (choice2 == "2")
                {
                    Console.WriteLine("Binary: ");//Binary conversion
                    string bin = Console.ReadLine();
                    int decValue = Convert.ToInt32(bin, 2);
                    string hexValue = decValue.ToString("X");
                    Console.WriteLine($"Decimal = {decValue}\nHex = {hexValue}");
                }
                else if (choice2 == "3")
                {
                    Console.WriteLine("Hex: ");//Hex conversion
                    string hex = Console.ReadLine();
                    int decValue = Convert.ToInt32(hex, 16);
                    string binaryValue = Convert.ToString(decValue, 2);
                    while (binaryValue.Length < 8)//I like the way this while loop makes the binary number tidier when working with small numbers, while also alowing for larger binary numbers too
                    {
                        binaryValue = "0" + binaryValue;
                    }
                    Console.WriteLine($"Binary = {binaryValue}\nDecimal = {decValue}");
                }
                else if (choice == "4")
                {
                    Console.WriteLine("BCD: ");
                }
                else
                {
                    Console.WriteLine("\nInvalid option");
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                    return;
                }
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
        public static void Matrices()//Fin
        {
            Console.WriteLine("Matrices Calculator: ");
            Console.WriteLine("1. Addition\n2. Subtraction\n3. Dot Product\n4. Scalar\n5. Determinant");
            string choice = Console.ReadLine();
            Console.WriteLine("\na: b: c: d:");//Asks the user for 4 numbers
            string input1 = Console.ReadLine();//stores as input1
            string[] numbers1 = input1.Split(" ");//splits at each " "
            double a = Convert.ToDouble(numbers1[0]);
            double b = Convert.ToDouble(numbers1[1]);
            double c = Convert.ToDouble(numbers1[2]);
            double d = Convert.ToDouble(numbers1[3]);//stores each number in the numbers array

            if (choice == "1")
            {
                Console.WriteLine("\ne: f: g: h:");//Asks the user for 4 more numbers numbers
                string input2 = Console.ReadLine();
                string[] numbers2 = input2.Split(" ");
                double e = Convert.ToDouble(numbers2[0]);
                double f = Convert.ToDouble(numbers2[1]);
                double g = Convert.ToDouble(numbers2[2]);
                double h = Convert.ToDouble(numbers2[3]);//process repeats itself

                double num1 = a + e;
                double num2 = b + f;
                double num3 = c + g;
                double num4 = d + h;//Had all the equations in my maths book haha
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

        public static void GandV()//Fin
        {
            Console.WriteLine("Matrices Calculator: ");
            Console.WriteLine("1. Distance between two points\n2. Midpoint between two points\n3. Gradient\n4. Radians to Degrees\n5. Degrees to Radians\n6. Addition and Subtraction of Vectors\n7.Dot Product");
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
            else if (choice == "4")
            {
                Console.WriteLine("\nr: ");
                double radian = Convert.ToDouble(Console.ReadLine());
                double degrees = radian * (180 / Math.PI);
                Console.WriteLine($"= {degrees}");
            }
            else if (choice == "5")
            {
                Console.WriteLine("\nd: ");
                double degrees = Convert.ToDouble(Console.ReadLine());
                double radian = degrees * (Math.PI / 180);
                Console.WriteLine($"= {radian}");
            }
            else if (choice == "6")
            {
                Console.WriteLine("\na1: a2: op: b1: b2:");
                string input = Console.ReadLine();
                string[] numbers = input.Split(" ");
                double a1 = Convert.ToDouble(numbers[0]);
                double a2 = Convert.ToDouble(numbers[1]);
                string op = numbers[2];//grabs the operator
                double b1 = Convert.ToDouble(numbers[3]);
                double b2 = Convert.ToDouble(numbers[4]);
                if (input.Contains("+"))//Plus
                {
                    op = "+";
                    double c1 = a1 + b1;
                    double c2 = a2 + b2;
                    Console.WriteLine($"= {c1}/{c2}");
                }
                else if (input.Contains("-"))//Minus
                {
                    op = "-";
                    double c1 = a1 - b1;
                    double c2 = a2 - b2;
                    Console.WriteLine($"= {c1}/{c2}");
                }
            }
            else if (choice == "7")
            {
                Console.WriteLine("\na1: a2: b1: b2:");
                string input = Console.ReadLine();
                string[] numbers = input.Split(" ");
                double a1 = Convert.ToDouble(numbers[0]);
                double a2 = Convert.ToDouble(numbers[1]);
                double b1 = Convert.ToDouble(numbers[2]);
                double b2 = Convert.ToDouble(numbers[3]);
                double c1 = a1 * b1;
                double c2 = a2 * b2;
                double dot = c1 + c2;
                if (dot > 0)
                {
                    Console.WriteLine($"\n{c1} + {c2} = {dot}");
                    Console.WriteLine("= Positive");
                }
                else if (dot < 0)
                {
                    Console.WriteLine($"\n{c1} + {c2} = {dot}");
                    Console.WriteLine("= Negative");
                }
                else
                {
                    Console.WriteLine("Clash");
                }
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
            Console.WriteLine("1. Primality\n2. RNG\n3. Bar Codes");
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
            else if (choice == "2")
            {
                Console.WriteLine("\nx: a: c: mod:");
                string input = Console.ReadLine();
                string[] numbers = input.Split(" ");
                int x = Convert.ToInt32(numbers[0]);
                int a = Convert.ToInt32(numbers[1]);
                int c = Convert.ToInt32(numbers[2]);
                int mod = Convert.ToInt32(numbers[3]);
                int start = x;
                int count = 0;
                x = (a * x + c) % mod;//Work in progress...
                Console.WriteLine($"({a} * {start} + {c}) mod{mod} = {x}");
                while (x != start && count < mod * 2)//Could repeat forever so mod * 2 prevents that by giving a number for it to finish at, When count reahces that number
                {
                    int old = x;
                    x = (a * x + c) % mod;
                    Console.WriteLine($"({a} * {old} + {c}) mod{mod} = {x}");//Work in progress...
                    count++;
                }
                int xi = (a * x + c) % mod;
                Console.WriteLine($"({a} * {x} + {c}) mod{mod} = {xi}");//Work in progress...
            }
            else if (choice == "3")
            {
                Console.WriteLine("\nCalculator:");
                string input = Console.ReadLine();
                if (input.Length == 13)
                {
                    string prefix = input.Substring(0, 3);

                    if (prefix == "978" || prefix == "979")//ISBN can be 13 digits, but only if code starts with 978 or 979
                    {
                        Console.WriteLine("\n= ISBN-13");
                    }
                    else
                    {
                        Console.WriteLine("\n= EAN-13");//EAN is 13 digits long, not starting with 978 or 979
                    }
                }
                else if (input.Length == 12)//UPC-A is exactly 12 numbers
                {
                    Console.WriteLine("\n= UPC-A");
                }
                else if (input.Length == 10)//ISBN can also be 10 numbers
                {
                    Console.WriteLine("\n= ISBN");
                }
                else
                {
                    Console.WriteLine("\n= Invalid Code");//Got these answers from google
                }
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

        public static void Cryptography()
        {
            Console.WriteLine("Number Theory and Encryption: ");
            Console.WriteLine("1. Encrypt n + 3\n2. Decrypt n - 3\n3. Encrypt aP + b\n4. Decrypt aP - b");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("\nCalculator:");
                string input = Console.ReadLine().ToUpper();//Stores the word to encrypt
                string encrypted = "";//Makes an empty string
                for (int i = 0; i < input.Length; i++)//Loops once for each character in the user's input
                {
                    char oldLetter = input[i]; //Gets the current character from the input string
                    int num = oldLetter - 'A'; //Tried doing - 1 but letters are stored as ASCII values, so subtract 'A' to get 0-25
                    int encrypt = (num + 3) % 26; //Moves the number 3 positions mod by 26
                    char newLetter = (char)(encrypt + 'A'); //turns the number back into a letter
                    encrypted += newLetter; //Adds the encypted letter to our empty strin from before the for loop.
                }
                Console.WriteLine($"= {encrypted}");//Once loop is over it prints the answer
            }
            else if (choice == "2")
            {
                Console.WriteLine("\nCalculator:");
                string input = Console.ReadLine().ToUpper();//Pretty much the same process
                string encrypted = "";
                for (int i = 0; i < input.Length; i++)
                {
                    char oldLetter = input[i];
                    int num = oldLetter - 'A';
                    int encrypt = (num - 3) % 26; //except we move the number back 3 spaces to decrypt. 
                    char newLetter = (char)(encrypt + 'A');
                    encrypted += newLetter;
                }
                Console.WriteLine($"= {encrypted}");
            }
            else if (choice == "3") //The Affine Cypher was a bit confusing for me
            {
                Console.WriteLine("\nCalculator:");
                Console.WriteLine("\nInput: ");
                string input = Console.ReadLine().ToUpper();
                string encrypted = "";
                Console.WriteLine("\nInput: a: b: ");
                string input1 = Console.ReadLine();
                string[] numbers = input1.Split(" ");
                int a = Convert.ToInt32(numbers[0]);
                int b = Convert.ToInt32(numbers[1]);
                for (int i = 0; i < input.Length; i++)
                {
                    char oldLetter = input[i];
                    int num = oldLetter - 'A';
                    int encrypt = (a * num + b) % 26;//So i used the provided calculation in the assignment document 
                    char newLetter = (char)(encrypt + 'A');
                    encrypted += newLetter;//While following the same process to create the encrypted word
                }
                Console.WriteLine($"= {encrypted}");
            }
            else if (choice == "4")
            {
                Console.WriteLine("\nCalculator:");
                Console.WriteLine("\nInput: ");
                string input = Console.ReadLine().ToUpper();
                string encrypted = "";
                Console.WriteLine("\nInput: a: b: ");
                string input1 = Console.ReadLine();
                string[] numbers = input1.Split(" ");
                int a = Convert.ToInt32(numbers[0]);
                int b = Convert.ToInt32(numbers[1]);
                for (int i = 0; i < input.Length; i++)
                {
                    char oldLetter = input[i];
                    int num = oldLetter - 'A';
                    int encrypt = (a * num - b) % 26; //And used num - b for decryption
                    char newLetter = (char)(encrypt + 'A');
                    encrypted += newLetter;
                }
                Console.WriteLine($"= {encrypted}");
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
