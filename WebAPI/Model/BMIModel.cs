﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class BMIModel
    {
        public double heightInFeet { get; set; }
        public double heightInInches { get; set; }
        public double weight { get; set; }

<<<<<<< HEAD
        public BMIModel()
        {

        }

=======
>>>>>>> d64fa71a04e68f34f8e417d7c71963941734956f
        public BMIModel(double heightInFeet, double heightInInches, double weight)
        {
            this.heightInFeet = heightInFeet;
            this.heightInInches = heightInInches;
            this.weight = weight;
        }
    }
}
