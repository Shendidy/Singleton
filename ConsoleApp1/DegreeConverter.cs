using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class DegreeConverter
    {
        public static double ConvertToFahrenheit(double celsius) => celsius * 9 / 5 + 32;

        public static double ConvertToCelsius(double fahrenheit) => ((fahrenheit - 32) * 5 / 9);
    }
}
