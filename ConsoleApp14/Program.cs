namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task 1");
            
            Film f = new Film();
            f.show();

            Console.WriteLine("task 2");
            
            using (Theatre theatre = new Theatre())
            {
                theatre.show();
            }

            Console.ReadLine();
        }
    }
}