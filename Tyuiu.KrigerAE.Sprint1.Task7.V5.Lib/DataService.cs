﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KrigerAE.Sprint1.Task7.V5.Lib
{
    public class DataService : ISprint1Task7V5

    {
        public double Calculate(double x)
        {
            return Math.Round((Math.Log(Math.Abs(Math.Cos (x))))/(Math.Log(1+x*x)),3);
        }
    }
}
