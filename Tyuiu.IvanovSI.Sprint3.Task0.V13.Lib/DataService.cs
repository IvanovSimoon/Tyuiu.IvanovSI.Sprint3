using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.IvanovSI.Sprint3.Task0.V13.Lib
{
    public class DataService : ISprint3Task0V13
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + ((Math.Pow(value,i)+1/2)*Math.Cos(i));
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
