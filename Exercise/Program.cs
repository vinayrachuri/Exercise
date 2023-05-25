using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Exercise1");
        Console.WriteLine("2. Exercise2");
        Console.WriteLine("3. Exercise3a");
        Console.WriteLine("4. Exercise3b");
        Console.WriteLine("5. Exercise4a");
        Console.WriteLine("6. Exercise4b");
        Console.WriteLine("7. Exercise5");
        Console.WriteLine("8. Exercise6");
        Console.WriteLine("0 Exit");
        string selectAction = Console.ReadLine();

        while (selectAction != "0")
        {
            switch (selectAction)
            {
                case "1":
                    // C# Program to Print Odd Numbers in a Given Range
                    for (int j = 1; j < 20; j++)
                    {
                        if (j % 2 != 0)
                        {
                            Console.WriteLine(j);
                        }
                    }
                    break;

                case "2":
                    // C# Program to Find the Largest of Three Numbers
                    int number1, number2, number3;
                    Console.WriteLine("Enter the number num1");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the number num2");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the number num3");
                    number3 = Convert.ToInt32(Console.ReadLine());

                    if (number1 > number2 && number1 > number3)
                    {
                        Console.WriteLine("num1 is the largest");
                    }
                    else if (number2 > number1 && number2 > number3)
                    {
                        Console.WriteLine("num2 is the largest");
                    }
                    else
                    {
                        Console.WriteLine("num3 is the largest");
                    }
                    break;

                case "3":
                    // C# Program to Swap Two Numbers with a 3rd variable
                    int num1, num2;
                    Console.WriteLine("Enter the number num1");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the number num2");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    int temp = num1;
                    num1 = num2;
                    num2 = temp;

                    Console.WriteLine("Numbers after swapping");
                    Console.WriteLine("num1 " + num1);
                    Console.WriteLine("num2 " + num2);
                    break;

                case "4":
                    // C# Program to Swap Two Numbers without using a 3rd variable
                    int n1, n2;
                    Console.WriteLine("Enter the number num1");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the number num2");
                    n2 = Convert.ToInt32(Console.ReadLine());

                    n1 = n1 + n2;
                    n2 = n1 - n2;
                    n1 = n1 - n2;

                    Console.WriteLine("Numbers after swapping");
                    Console.WriteLine("num1 " + n1);
                    Console.WriteLine("num2 " + n2);
                    break;

                case "5":
                    // C# Program to Find the Sum of All the Multiples of 3 and 5 under a given limit number
                    Console.WriteLine("Enter limit:");
                    int limit = Convert.ToInt32(Console.ReadLine());
                    int sum = 0;

                    for (int i = 0; i < limit; i++)
                    {
                        if (i % 3 == 0 || i % 5 == 0)
                        {
                            sum += i;
                        }
                    }

                    Console.WriteLine("The sum of multiples: " + sum);
                    break;

                case "6":
                    // C# Program to Find the Sum of All the Multiples of 5 under a given limit number
                    Console.WriteLine("Enter limit:");
                    int lim = Convert.ToInt32(Console.ReadLine());
                    int summ = 0;

                    for (int i = 0; i < lim; i++)
                    {
                        if (i % 5 == 0)
                        {
                            summ += i;
                        }
                    }

                    Console.WriteLine("The sum of multiples: " + summ);
                    break;

                case "7":
                    // C# Program to Print All the Multiples of 17 which are Less than 100
                    int limitNum = 100;

                    for (int i = 1; i < limitNum; i++)
                    {
                        if (i % 17 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;

                case "8":
                    // C# Program to Find Sum of Digits of a Number
                    Console.WriteLine("Enter a Number:");
                    int number = Convert.ToInt32(Console.ReadLine());
                    int sumOfDigits = 0;
                    int tempNum = number;

                    while (tempNum != 0)
                    {
                        int digit = tempNum % 10;
                        sumOfDigits += digit;
                        tempNum /= 10;
                    }

                    Console.WriteLine("Sum of the digits: " + sumOfDigits);
                    break;

                default:
                    Console.WriteLine("Invalid exercise number");
                    break;
            }

            Console.WriteLine("1. Exercise1");
            Console.WriteLine("2. Exercise2");
            Console.WriteLine("3. Exercise3a");
            Console.WriteLine("4. Exercise3b");
            Console.WriteLine("5. Exercise4a");
            Console.WriteLine("6. Exercise4b");
            Console.WriteLine("7. Exercise5");
            Console.WriteLine("8. Exercise6");
            Console.WriteLine("0 Exit");
            selectAction = Console.ReadLine();
        }
    }
}
