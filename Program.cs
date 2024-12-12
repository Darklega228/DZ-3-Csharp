namespace DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество ступеней лесенки: ");
            int steps = int.Parse(Console.ReadLine());

            for (int i = 1; i <= steps; i++)
            {
                Console.WriteLine(new string('*', i));
            }

            Console.WriteLine("Лесенка завершена!");
            Console.ReadKey();
        }
    }
}
