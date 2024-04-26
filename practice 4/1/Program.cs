namespace _1;

class MyClass
{
    static int StrToInt(string input) 
    {
        int result = 0;
        for (int i = 0; i < input.Length; i++) 
        {
            if (i + 1 < input.Length && GetValue(input[i]) < GetValue(input[i + 1])) 
            {
                result -= GetValue(input[i]);
            } 
            else 
            {
                result += GetValue(input[i]);
            }
        }
        return result;
    }

    static int GetValue(char c)                                         
    {
        switch (c) 
        {
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M':
                return 1000;
            default:
                return 0;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите ваше римское число: ");
        string line = Console.ReadLine();
        
        Console.WriteLine(StrToInt(line));
    }
}

    