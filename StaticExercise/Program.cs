using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var fahrenheit = TempConverter.CelsiusToFahrenheit(90);
            var celsius = TempConverter.FahrenheitToCelsius(90);

            Console.WriteLine("The amount of degrees converts differently.");

            Console.WriteLine($"90 degrees in fahrenheit converts to {celsius} degrees in celsius");
            Console.WriteLine($"90 degrees in celsius converts to {fahrenheit} degres in fahrenheit");
        }
    }
}
