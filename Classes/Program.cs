namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car() { Make = "Toyota", Model = "Highlander", Year = 2019 };
            Console.WriteLine(myCar.Make);
            Console.WriteLine(myCar.Model);
            Console.WriteLine(myCar.Year);
        }
    }
}
