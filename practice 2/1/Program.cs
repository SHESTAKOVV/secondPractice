namespace _1;

 public class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите дату рождения: ");
            DateTime BirthDay = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введите фамилию: ");
            string surname = (Console.ReadLine());

            Console.WriteLine("Введите вашу группу: ");
            int groupNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваши последние 5 оценок: ");

            int[] Grate = new int[5];

            for (int i = 0; i < Grate.Length; i++)
            {
                Console.WriteLine("Поставьте пять пожф=алуйста, Семен Александрович ");
                Grate[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\r\n");

            Student student = new Student(surname, BirthDay, groupNumber, Grate);

            student.EditInformationAboutStudent();
            student.Print();
        }
    }

    class Student
    {
        internal string surname { set; get; }

        internal DateTime DateOfBirth { set; get; }

        internal int GroupNumber { set; get; }

        internal int[] Grate { set; get; } = new int[5];

        public Student(string surname, DateTime DateOfBirth, int groupNumber, int[] Grate)
        {
            this.surname = surname;
            this.DateOfBirth = DateOfBirth;
            GroupNumber = groupNumber;
            this.Grate = Grate;
        }

        public void Print()
        {
            Console.WriteLine("Вывод информации о пользователе: ");
            Console.WriteLine($"Введенная фамилия: {surname} ");
            Console.WriteLine($"Введенная дата рождения: {DateOfBirth: dd-MMMM-yyyy} ");

        }

        public void EditInformationAboutStudent()
        {
            Console.WriteLine("Введите новую фамилию: ");
            surname = Console.ReadLine();

            Console.WriteLine("Введите новуб дату рождения: ");
            DateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введите новую группу: ");
            GroupNumber = int.Parse(Console.ReadLine());
        }
    }

