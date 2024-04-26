namespace _2;

public class Program
{
        
    static void Main(string[] args)
    {
        string pointNumber = "Tomsk - Лучаново";
        Console.WriteLine($"Пользователь, введи номер поезда. ");
        int trainNumber = int.Parse(Console.ReadLine());
            
        Console.WriteLine($"Введите время отправки ");
        DateTime departureTime = DateTime.ParseExact(Console.ReadLine(),"HH:mm", null);
            
        Console.WriteLine($"Информация о введенном пользователе:");
        Train train = new Train(trainNumber, pointNumber , departureTime);
            
        Console.WriteLine($"Информация об отправке: {train.PointName}\n" +
                          $"Информция о номере поезда: {train.TrainNumber}\n" +
                          $"Информация о времени выезда: {train.DepartureTime:HH:mm}");
    }
}
    
class Train
{  
    internal string PointName { set; get; }
        
    internal int TrainNumber { set; get; }
        
    internal DateTime DepartureTime { set; get; }

    public Train(int trainNumber, string pointName, DateTime departureTime)
    {
        TrainNumber = trainNumber;
        PointName = pointName;
        DepartureTime = departureTime;
    }
}