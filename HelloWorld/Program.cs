// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// old way of things
using System;
using System.IO.Compression;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // string characterName = "Name im making it longer";
            // int characterNumber;
            // characterNumber = 45;

            // // data types:
            // char signleLetterAndCharac = 'A';
            // const int pop = 5;

            // bool isMale = true; //or false
            // // float, double, decimal --> from least acuuracy to precise. for decimal numbers

            // Console.WriteLine("I can append strings like: " + characterName);
            // Console.WriteLine("I can add strings and ints: " + characterNumber + " like: " + characterName);

            // Console.WriteLine(characterName.Contains("me")); // Find method
            // Console.WriteLine(characterName[5]); // indexing []
            // Console.WriteLine(characterName.IndexOf('m')); // returns the index of 1st 'm' character 
            // string bop = characterName.Substring(5, 9);

            // Console.WriteLine(bop.Length);
            // Console.WriteLine(bop);

            // Console.WriteLine(5 / 2); // returns an integer

            // Console.WriteLine(5 / 2.0); // returns a float 

            // characterNumber++; // increament 
            // characterNumber--; // decreament

            // Console.Write("Please enter your name: ");
            // int user_num = Convert.ToInt32(Console.ReadLine()); // string to int from user input

            // Console.WriteLine($"Hi {user_num} welcome to my world!");

            // -------------------
            // Simple Calculator.
            // Console.Write("Please enter your 1st num: ");
            // double user_num = Convert.ToDouble(Console.ReadLine()); // string to int from user input

            // Console.Write("Please enter your 2nd num: ");
            // double user_2num = Convert.ToDouble(Console.ReadLine()); // string to int from user input

            // Console.WriteLine($"New number is: {user_num + user_2num}");


            // --------------------
            // Arrays
            // int[] Luckynumber = [1, 2, 3, 4];
            // string [] SpecialWords = ["Young", "Bob", "Sam"];
            // string [] SpecailList = new string[5];

            // SpecailList[0] = "god of war";
            // SpecailList[1] = "Nope"; 
            // SpecailList[2] = "yes";

            // Luckynumber[0] = 900;

            // Console.WriteLine(Luckynumber[0]);

            // Console.ReadLine(); // not needed

            // Calling the Function:
            // Console.Write("Please enter your name: ");
            // string user_name = Console.ReadLine();

            // Console.Write("Please enter your age: ");
            // int age = Convert.ToInt32(Console.ReadLine());

            // SayHi(user_name, age);
            // Console.WriteLine(Cubbing(5));

            // ----------------
            // if statemeants
            // bool isMale = true;
            // bool isTall = false;

            // if (isMale && !isTall)
            // {
            //     Console.WriteLine("You are male");
            // }
            // else if (isMale == false)
            // {
            //     Console.WriteLine("You are not male");
            // }

            // Console.WriteLine(Getmax(20, 9, 40));

            // Console.WriteLine(SimpCalc(65.5, 4.32, "[]"));

            // Console.WriteLine(GetDay(7));

            // While loop ----------
            // int nn = 1;
            // while (nn <= 5)
            // {
            //     Console.WriteLine($" this is loop {nn}");
            //     nn++;
            // }

            // Do While loop ----------
            // do
            // {
            //     Console.WriteLine($" this is loop {nn}");
            //     nn++;
            // } while (nn <= 5);

            //------------------
            // Guessing game
            // string wordd = "Young";
            // string guess = "";
            // int guessNum = 3;
            // while (guessNum > 0)
            // {
            //     guessNum--;
            //     Console.Write("Please guess a word: ");
            //     guess = Console.ReadLine();

            //     if (guess == wordd)
            //     {
            //         Console.WriteLine("You win");
            //         break;
            //     }
            //     else
            //     {
            //         Console.WriteLine($"You have {guessNum} more chances");
            //     }


            // }
            // Console.WriteLine("You lose :(");

            //  For Loop

            string[] spNum = ["bob", "lela", "sam", "ben", "can"];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(spNum[i]);
            }


        }
        static string GetDay(int day)
        {
            string dayname;
            // Switch case
            switch (day)
            {
                case 0:
                    dayname = "Sunday";
                    break;
                case 1:
                    dayname = "Monday";
                    break;
                case 2:
                    dayname = "Tuesday";
                    break;
                default:
                    dayname = "Invaild response";
                    break;
            }

            return dayname;
        }

        static void SayHi(string name, int age) //Functions in C#
        {
            Console.WriteLine($"Hello {name} you are {age} years old!");
        }

        static int Cubbing(int num)
        {
            int result = num * num * num;
            return result;
        }

        static int Getmax(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }

        static double SimpCalc(double num1, double num2, string op)
        {
            double result;

            if (op == "+")
            {
                result = num1 + num2;
            }
            else if (op == "-")
            {
                result = num1 - num2;
            }
            else if (op == "/")
            {
                result = num1 / num2;
            }
            else if (op == "*")
            {
                result = num1 * num2;
            }
            else
            {
                Console.WriteLine("Invalid operator");
                result = 00;
            }

            return result;
        }

    }
}
