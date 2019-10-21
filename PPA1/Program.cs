using Model;
using System;
using System.Collections.Generic;
using Microsoft.Owin.Hosting;
using System.Net.Http;

namespace PPA1
{
    public class Program
    {
        static Functions f = new Functions();
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            while(true)
            {
                Console.WriteLine("1. BMI");
                Console.WriteLine("2. Retirement");
                Console.WriteLine("3. Distance");
                Console.WriteLine("4. Split the Tip");
                Console.Write("Select a function (1-4) or 5 to exit: ");
                string numString = Console.ReadLine();
                int num;
                try
                {
                    num = Int32.Parse(numString);
                }
                catch(Exception e)
                {
                    continue;
                }
                switch(num)
                {
                    case 1:
                        BMIInput();
                        break;
                    case 2:
                        RetireInput();
                        break;
                    case 3:
                        DistanceInput();
                        break;
                    case 4:
                        SplitInput();
                        break;
                    case 5:
                        goto exit;
                    default:
                        continue;
                }
            }
            exit:
            return; 
        }

        static void BMIInput()
        {
            Console.WriteLine();
            while (true)
            {
                LogContext db = new LogContext(Config.dockerConnectionString);
                Console.WriteLine("Prior Calls:");
                Console.WriteLine("Timestamp heightInFeet heightInInches weightInPounds Result");
                foreach(BMILog log in db.BMILogs)
                {
                    Console.WriteLine("\"" + log.timestamp + "\" " + log.heightFeet + " " + log.heightInches + " " + log.weight + " " + log.result);
                }
                Console.WriteLine("Enter 3 numbers on each line in the form: \nheightInFeet (double) \nHeightInInches (double) \nWeightInPounds (double)");
                double heightInFeet, heightInInches, weightInPounds;
                try
                {
                    heightInFeet = Double.Parse(Console.ReadLine());
                    heightInInches = Double.Parse(Console.ReadLine());
                    weightInPounds = Double.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    continue;
                }
                Console.WriteLine();
                Console.WriteLine(f.BMI(heightInFeet, heightInInches, weightInPounds,db));
                Console.WriteLine();
                break;
            }
        }

        static void RetireInput()
        {
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Enter 4 numbers on each line in the form: \nage (int) \nsalary (double) \npercentage (double) \ngoal (double)");
                int age;
                double salary, percentage, goal;
                try
                {
                    age = Int32.Parse(Console.ReadLine());
                    salary = Double.Parse(Console.ReadLine());
                    percentage = Double.Parse(Console.ReadLine());
                    goal = Double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    continue;
                }
                Console.WriteLine();
                Console.WriteLine(f.Retire(age, salary, percentage, goal));
                Console.WriteLine();
                break;
            }
        }

        static void DistanceInput()
        {
            Console.WriteLine();
            while (true)
            {
                LogContext db = new LogContext(Config.dockerConnectionString);
                Console.WriteLine("Prior Calls:");
                Console.WriteLine("Timestamp heightInFeet heightInInches weightInPounds Result");
                foreach (DistanceLog log in db.DistanceLogs)
                {
                    Console.WriteLine("\"" + log.timestamp + "\" " + log.x1 + " " + log.y1 + " " + log.x2 + " " + log.y2 + " " + log.result);
                }
                Console.WriteLine("Enter 4 numbers on each line in the form: \nx1 (double) \ny1 (double) \nx2 (double) \ny2 (double)");
                double x1, y1, x2, y2;
                try
                {
                    x1 = Double.Parse(Console.ReadLine());
                    y1 = Double.Parse(Console.ReadLine());
                    x2 = Double.Parse(Console.ReadLine());
                    y2 = Double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    continue;
                }
                Console.WriteLine();
                Console.WriteLine(f.Distance(x1, y1, x2, y2,db));
                Console.WriteLine();
                break;
            }
        }

        static void SplitInput()
        {
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Enter 2 numbers on each line in the form: \namount (double without dollar sign) \nnumberOfPeople (int)");
                double amount;
                int numberOfPeople;
                try
                {
                    amount = Double.Parse(Console.ReadLine());
                    numberOfPeople = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    continue;
                }
                Console.WriteLine();
                List<double> l = f.Split(amount, numberOfPeople);
                for(int i = 0; i < l.Count; i++)
                {
                    if(i != 0)
                    {
                        Console.Write(", ");
                    }
                    Console.Write("$" + l[i]);
                }
                Console.WriteLine();
                Console.WriteLine();
                break;
            }
        }
    }
}
