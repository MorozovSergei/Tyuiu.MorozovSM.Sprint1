﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MorozovSM.Sprint1.Task7.V4.Lib
{
    public class DataService : ISprint1Task7V4
    {
        public double Calculate(double x, double y)
        {
            double z;
            z = double.Round(Math.Log(Math.Abs((y - Math.Sqrt(Math.Abs(x)))*(x - (y/(x + Math.Pow(x,2)/4))))),3);
            return z;
        }
    }
}
