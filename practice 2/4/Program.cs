namespace _4;

public class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        Counter counter = new Counter(num);
            
        Counter.Summer();
    }
    
    class Counter
    {
        internal static int num { get; set; }

        public Counter(int number)
        {
            num = number;
        }

        public static void Summer()
        {
            int sum = num + num;
            Console.WriteLine($"Ваше число, увличенное само на себя: {sum}");
        }
    }
}