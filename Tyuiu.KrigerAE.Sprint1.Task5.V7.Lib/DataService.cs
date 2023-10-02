using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KrigerAE.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            
            int degreesPerHour = 360 / 12;
            int hours = Convert.ToInt32(f) / degreesPerHour;

            return hours;
        }
    }
}
