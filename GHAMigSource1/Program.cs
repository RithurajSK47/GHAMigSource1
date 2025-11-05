namespace GHAMigSource1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the values of a and b");

            string? inputA = Console.ReadLine();
            string? inputB = Console.ReadLine();

            if (int.TryParse(inputA, out a) && int.TryParse(inputB, out b))
            {
                int sum = a + b;
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter valid integers.");
            }

        }
    }
}
