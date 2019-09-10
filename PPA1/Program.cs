using System;

namespace PPA1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Functions f = new Functions();
            while(true)
            {
                Console.WriteLine("1. ");
                Console.WriteLine("2. ");
                Console.WriteLine("3. ");
                Console.WriteLine("4. ");
                Console.Write("Select a function (1-4) or 5 to exit: ");
                string numString = Console.ReadLine();
                int num;
                try
                {
                    num = Int32.Parse(numString);
                }
                catch(Exception e)
                {
                    goto skip;
                }
                switch(num)
                {
                    case 1:
                        f.BMI(1,1,1);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        goto exit;
                    default:
                        goto skip;

                }
                skip:
                continue;
            }
            exit:
            return; 
        }
    }
}
