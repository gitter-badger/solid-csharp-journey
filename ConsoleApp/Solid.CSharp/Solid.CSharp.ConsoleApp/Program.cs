﻿using System;
using System.Text;
using Solid.DSharp;

namespace Solid.CSharp.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var res = "n";
            do
            {
                //basic();
                //dataTypes();
                //ControlStatmentsExample();
                //LoopingStatements();
                //StringConcatenation();
                //ClassAndObjects();
                ClassAndObjectsV2();

                Console.WriteLine("Do you want to run once more? (y/n)");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");
        }

        private static void ClassAndObjectsV2()
        {
            try
            {
                // StudentInfo nabin = new StudentInfo("Nabin");
                StudentInfo student = new StudentInfo();
                Console.WriteLine("Enter the name");
                student.Name = Console.ReadLine();
                Console.WriteLine("Enter the age");
                student.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Math");
                student.Math = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Info is \nName : {student.Name}\nAge : {student.Age}\nMath : {student.Math}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ClassAndObjects()
        {
            HumanBeing nabin = new HumanBeing();
            HumanBeing bhim = new HumanBeing();
            nabin = new HumanBeing();
            nabin.age = 10;
            var i = 10;
            bhim = new HumanBeing(i);
            bhim.age = 12;
            Console.WriteLine(bhim.age);
        }

        private static void StringConcatenation()
        {
            string a = "Hello";
            string b = "World";
            string res1 = a + " " + b; //concatenation

            //formatting
            string template = "{0} {1}";
            var res2 = string.Format(template, a, b);

            //string interpolation
            var res3 = $"{a} {b}, => {a} and {b}";

            //string builder
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dear Sir,");
            sb.AppendLine("\tLorem ipsum dolor sit amet consectetur adipisicing elit. Eaque odit id totam consectetur hic velit minima veritatis doloremque magnam! Quia dolor quis eum, ut dicta perspiciatis sapiente illum laborum aliquid.");
            sb.AppendLine("Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque odit id totam consectetur hic velit minima veritatis doloremque magnam! Quia dolor quis eum, ut dicta perspiciatis sapiente illum laborum aliquid.");
            var result = sb.ToString();
            Console.WriteLine(result);
        }

        private static void LoopingExamplesV2()
        {
            string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            for (int i = 0; i < days.Length - 1; i++)
            {
                Console.WriteLine("The day is {0}", days[i]);
            }

            foreach (var item in days)
            {
                Console.WriteLine(item);
            }
        }

        private static void LoopingStatements()
        {
            //known quantity and unknown quantity
            //for, foreach, while, do while
            Console.WriteLine("Enter the number");
            var num = Convert.ToInt32(Console.ReadLine());

            {
                Console.WriteLine("===========================");
                Console.WriteLine("using do while");
                int i = 1;
                do
                {
                    if (i == 5)
                    {
                        i++;
                        continue;
                    }
                    Console.WriteLine(num + " x " + i + " = " + num * i);
                    i++;
                } while (i <= 10);
            }

            {
                Console.WriteLine("===========================");
                Console.WriteLine("using while");
                int i = 1;
                while (i <= 10)
                {
                    Console.WriteLine(num + " x " + i + " = " + num * i);
                    i++;
                }
            }

            {
                Console.WriteLine("===========================");
                Console.WriteLine("using for loop");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(num + " x " + i + " = " + num * i);
                }
            }
        }

        private static void ControlStatmentsExample()
        {
            Console.WriteLine("Enter the number of day");
            var num = Convert.ToInt32(Console.ReadLine());

            ifElseStatement(num);

            switchCaseStatement(num);
            //(condition) ? <true statement> : <false statement>
        }

        private static void ifElseStatement(int num)
        {
            if (num == 1) Console.WriteLine("Sunday");
            else if (num == 2) Console.WriteLine("Monday");
            else if (num == 3) Console.WriteLine("Tuesday");
            else if (num == 4) Console.WriteLine("Wednesday");
            else if (num == 5) Console.WriteLine("Thursday");
            else if (num == 6) Console.WriteLine("Friday");
            else if (num == 7) Console.WriteLine("Saturday");
            else Console.WriteLine("Not a Valid Day");
        }

        private static void switchCaseStatement(int num)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;

                case 2:
                    Console.WriteLine("Monday");
                    break;

                case 3:
                    Console.WriteLine("Tuesday");
                    break;

                case 4:
                    Console.WriteLine("Wednesday");
                    break;

                case 5:
                    Console.WriteLine("Thursday");
                    break;

                case 6:
                    Console.WriteLine("Friday");
                    break;

                case 7:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Not a Valid Day");
                    break;
            }
        }

        private static void dataTypes()
        {
            int e = 10; //32 bit signed integer number
            short s = 10; //16 bit int number
            e = 65546;
            s = (short)e;
            Console.WriteLine("Int value = " + e);
            Console.WriteLine("short value = " + s);

            //char > int > long > float > double
            //implicit casting
            char c = 'C';
            int i = c;
            long l = i;
            float f = l;
            double d = f;

            //explicit casting
            f = (float)d;
            l = (long)f;
            i = (int)l;
            c = (char)i;
            c = (char)d;

            //string str = i.ToString();
            //int x = (int)str;
        }

        private static void basic()
        {
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("Name = " + name);
        }
    }
}