namespace _5;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Eduard!");
        var c = new MyClass(1, 1);
    }
    
    class MyClass
    {
        internal int Group { get; set; }
        internal int Plase { get; set; }

        public MyClass(int group, int plase)
        {
            Group = group;
            Plase = plase;
        }
            
        ~MyClass()
        {
            Console.WriteLine("dist");
        }
    }
}
