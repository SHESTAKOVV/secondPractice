namespace _1__2;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Ваше имя?");
        string name = Console.ReadLine();
            
        Console.WriteLine($"Ваша фамилия?");
        string surname = Console.ReadLine();
            
        Console.WriteLine($"Ваша ставка за день работы?");
        decimal rate = decimal.Parse(Console.ReadLine());
            
        Console.WriteLine($"Ваше количество отрабоанных дней? ");
        int days = int.Parse(Console.ReadLine());

        Worker worker = new Worker(name, surname, rate, days);
            
        worker.GetSelary();
        Console.WriteLine($"Ваша зарплата: " + worker.GetSelary());
    }
}

class Worker
{
    private string name;

    internal string Name
    {
        get => name;
        set =>  name = value;
            
    }

    private string surname;

    internal string Surname
    {
        get => surname;
        set => surname = value;
    }

    private decimal rate;

    internal decimal Rate
    {
        get => rate;
        set => rate = value;
    }
    
    private int days;

    internal int Days
    {
        get => days;
        set => days = value;
    }

    public Worker(string name, string surname, decimal rate, int days)
    {
        Name = name;
        Surname = surname;
        Rate = rate;
        Days = days;
    }

    public decimal GetSelary()
    {
        return Rate * Days;
    }
}

