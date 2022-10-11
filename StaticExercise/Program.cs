namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Math.Floor(TempConverter.FahrenheitToCelsius(90)));

            Console.WriteLine(Math.Floor(TempConverter.CelsiusToFahrenheit(32)));
        }
    }
}