namespace _3;

public  class Program
{
    internal static bool CheckOnRepetitions (int[] nums)
    {
        return nums.Length != nums.Distinct().Count();
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine($"Введите свой массив");
        Console.WriteLine($"Числа {CheckOnRepetitions(Console.ReadLine().Split(",").Select(int.Parse).ToArray())}");
    }
}