namespace calsius_to_fahrenheit
{
    internal class Program
    {
        static void TempConverter()
        {
           
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write the temperature in celsius degrees: " + c);

            double result = (c * 18) + 32;

            Console.WriteLine("C -> F = " + result); 

        }
        static void Main()
        {
            TempConverter();
        }
    }
}
