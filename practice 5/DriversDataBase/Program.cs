namespace pracrice_5;

/// <summary>
/// Класс Program
/// здесь описывается логика приложения
/// вызываем нужные методы пишем обработчики и тд
/// </summary>
public class Program 
{
    public static void Main(string[] args)
    {
        while (true)
        {
            
            Console.WriteLine("1. Просмотр типов машин:\n" +
                              "2. Добавление типов машин:\n" +
                              "3. Просмотр водителей:\n" +
                              "4. Добавление водителей:\n" +
                              "5. Просмотр машин:\n" +
                              "6. Добавление машин:\n" +
                              "7. Просмотр маршрутов:\n" +
                              "8. Дбавление маршрутов:\n" +
                              "9. Просмотр рейсов:\n" +
                              "10. Добавление рейсов:\n" +
                              "11. Добавление прав:\n" +
                              "12. Просмотр прав водителя:" );
            
            Console.WriteLine("Введите число для просмотра интересующего: ");

            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1 :
                    DatabaseRequests.GetTypeCarQuery();
                    break;
                case 2 :
                    Console.WriteLine("Введите тип машины");
                    DatabaseRequests.AddTypeCarQuery(Console.ReadLine());
                    break;
                case 3 :
                    DatabaseRequests.GetDriverQuery();
                    break;
                case 4 :
                    Console.WriteLine("Введите имя, затем фамилию, затем даут рождения.");
                    DatabaseRequests.AddDriverQuery(Console.ReadLine(), Console.ReadLine(), Convert.ToDateTime(Console.ReadLine()));
                    
                    Console.WriteLine("Введите номер водителя и номер прав");
                    DatabaseRequests.AddDriverRightsCategoryQuery(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    break;
                case 5 :
                    DatabaseRequests.GetCarQuery();
                    break;
                case 6 :
                    DatabaseRequests.AddCarQuery(int.Parse(Console.ReadLine()),Console.ReadLine(),Console.ReadLine(), uint.Parse(Console.ReadLine()));
                    break;
                case 7 :
                    DatabaseRequests.GetRoute();
                    break;
                case 8 :
                    DatabaseRequests.AddRoute(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()),uint.Parse(Console.ReadLine()));
                    break;
                case 9 :
                    DatabaseRequests.GetItinerary();
                    break;
                case 10 :
                    DatabaseRequests.AddItinerary(Console.ReadLine());
                    break;
                case 11 :
                    Console.WriteLine("Введите категорию прав");
                    DatabaseRequests.AddRightsCategoryQuery(Console.ReadLine());
                    break;
                case 12:
                    Console.WriteLine("Введите id водителя о котором вам показать информацию ");
                    DatabaseRequests.GetDriverRightsCategoryQuery(int.Parse(Console.ReadLine()));
                    break;
            }
            Console.ReadLine();
            Console.Clear();
        }  
    }
}