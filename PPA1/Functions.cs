using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PPA1
{
    public class Functions
    {
        public string BMI(double heightFeet, double heightInches, double weight, LogContext db)
        {
            BMILog log = new BMILog(DateTime.Now, heightFeet, heightInches, weight, "");
            if (heightFeet < 0 || heightInches < 0 || weight <= 0 || (heightFeet == 0 && heightInches == 0))
            {
                log.result = "Impossible";
                goto skip;
            } 
            weight *= .45;
            heightInches += 12 * heightFeet;
            heightInches *= .025;
            heightInches *= heightInches;
            double ans = weight / heightInches;
            ans = Math.Round(ans, 2);
            string result;
            if(ans < 18.5) {
                result = ans.ToString() + " Underweight";
            }
            else if(ans >= 18.5 && ans < 25)
            {
                result = ans.ToString() + " Normal weight";
            }
            else if(ans >= 25 && ans < 30)
            {
                result = ans.ToString() + " Overweight";
            }
            else
            {
                result = ans.ToString() + " Obese";
            }
            log.result = result;
            skip:
            db.BMILogs.Add(log);
            db.SaveChanges();
            return log.result;
        }

        public string Retire(int age, double salary, double percentage, double goal)
        {
            if(age < 0 || salary <= 0 || percentage <= 0 || goal < 0)
            {
                return "Impossible";
            }
            double yearlySavings = (salary * (percentage / 100) * 1.35);
            int numberOfYears = (int)Math.Ceiling(goal / yearlySavings);
            int goalAge = age + numberOfYears;
            if(goalAge >= 100)
            {
                return goalAge.ToString() + " years old" + ", you died!";
            }
            else
            {
                return goalAge.ToString() + " years old";
            }
        }

        public double Distance(double x1, double y1, double x2, double y2, LogContext db)
        {
            double result = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 2);
            DistanceLog log = new DistanceLog(DateTime.Now, x1, y1, x2, y2, result);
            db.DistanceLogs.Add(log);
            db.SaveChanges();
            return result;
        }

        public List<double> Split(double amount, int number)
        {
            List<double> ans = new List<double>();
            if (amount < 0 || number <= 0) return ans;
            amount *= 100;
            int val = (int)(amount / number);
            double amountD = (double)val / 100;
            int remainder = (int)amount % number;
            for(int i = 0; i < number; i++)
            {
                ans.Add(amountD + (i + 1 <= remainder ? .01 : 0));
            }
            return ans;
        }
    }
}
