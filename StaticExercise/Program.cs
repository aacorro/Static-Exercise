namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Temperature Conversion Calculator \nEnter a value to convert in Fahrenheit degrees: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            fahrenheit = Math.Floor(TempConverter.FahrenheitToCelsius(fahrenheit));
            Console.WriteLine($"The temperature is {fahrenheit} Fahrenheit degrees");


            Console.WriteLine($"Enter a value to convert in Celsius degrees: ");
            double celsius = double.Parse(Console.ReadLine());
            fahrenheit = Math.Floor(TempConverter.FahrenheitToCelsius(celsius));
            Console.WriteLine($"The temperature is {celsius} Celsius degrees");

        }
    }
}