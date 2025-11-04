namespace GHAMigSource1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("Enter the values of a and b");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int sum = a + b;

            Console.WriteLine($"The sum of two number is {sum}")
        }
    }
}
