namespace _3;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введи первое число: ");
        Console.WriteLine("Введи второе число: ");

        int num1 = int.Parse(Console.ReadLine());
        int nums2 = int.Parse(Console.ReadLine());
        
        NumCase1 numCase1 = new NumCase1(num1, nums2);

        numCase1.EditNums();
        numCase1.Printer();
        numCase1.SumNum();
        numCase1.BigestNum();
    }
        
    class NumCase1
    {
        internal int  Number1 { set; get; } = 0;
        internal int Number2 { set; get; } = 0;
            
        public NumCase1(int num1, int nums2)
        {
            Number1 = num1;
            Number2 = nums2; 
        }
            
        public void Printer()
        {
            Console.WriteLine($"Вывод gthdjuj xbckf целых чисел: {this.Number1} " + 
                              $"\nВывод вторых целых чисел: {this.Number2} ");
        }

        public void EditNums()
        {
            Console.WriteLine($"Введите новые чилса:");

            Number1 = int.Parse(Console.ReadLine());
            Number2 = int.Parse(Console.ReadLine());
                
        }

        public void SumNum()
        {
            int sum = Number1 + Number2;
            Console.WriteLine($"Сумма ваших чисел = {sum}");
        }

        public void BigestNum()
        {
                
            Console.WriteLine($"Число {(Number1 > Number2 ? Number1 : Number2)} - наибольшее");
                
        }
    }
}