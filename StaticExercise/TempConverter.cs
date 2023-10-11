using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace StaticExercise
{
    public static class TempConverter

    //Create a static class called TempConverter - DONE
    /*Create 2 methods inside the TempConverter class:
    Name the first method - FahrenheitToCelsius
    Name the second method - CelsiusToFahrenheit
    Both methods will have a single parameter of type double
    Complete the logic so that they properly convert the temperatures */

    {
        public static double FahrenheitToCelsius(double fahrenheit)
        
        {
            //fahrenheit conversion formula --> (temp - 32) * 5/9 (1.8)

            return (fahrenheit - 32) * 1.8; 
        }

        public static double CelsiusToFahrenheit(double celsius) 
        
        { 
            return (celsius *1.8) + 32;
        }
    }
}
