using System;
using System.Collections.Generic;
using System.Text;

namespace PPA1
{
    public class Functions
    {
        public string BMI(double heightFeet, double heightInches, double weight)
        {
            if(heightFeet <= 0 || heightInches <= 0 || weight <= 0)
            {
                return "Impossible";
            } 
            weight *= .45;
            heightInches += 12 * heightFeet;
            heightInches *= .025;
            heightInches *= heightInches;
            double ans = weight / heightInches;
            ans = Math.Round(ans, 2);
            if(ans < 18.5) {
                return ans.ToString() + " Underweight";
            }
            else if(ans >= 18.5 && ans < 25)
            {
                return ans.ToString() + " Normal weight";
            }
            else if(ans >= 25 && ans < 30)
            {
                return ans.ToString() + " Overweight";
            }
            else if(ans >= 30)
            {
                return ans.ToString() + " Obese";
            }
            return "Impossible";
        }

        public string Retire(int age, double salary, double percentage, double goal)
        {
            double yearlySavings = (salary * (percentage / 100) * 1.35);
            int numberOfYears = (int)Math.Ceiling(goal / yearlySavings);
            int goalAge = age + numberOfYears;
            if(goalAge >= 100)
            {
                return "You died";
            }
            else
            {
                return goalAge.ToString() + " years";
            }
        }
    }
}
