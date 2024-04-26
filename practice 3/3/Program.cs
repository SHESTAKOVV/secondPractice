namespace _3;

public class Program
{
    static void Main(string[] args)
    {
        Calculation calc = new Calculation();
        string cal = Console.ReadLine();
        calc.SetCalculationLine(cal);
    }
}

class Calculation
{
    private string calculationLine;

    public string CalculationLine
    {
        get { return calculationLine; }
        set { calculationLine = value; }
    }

    public void SetCalculationLine(string line)
    {
        CalculationLine = line;
    }

    public void SetLastSymbolCalculationLine(char symbhol)
    {
        CalculationLine += symbhol;
    }

    public string GetCalculationLine()
    {
        return CalculationLine;
    }

    public char GetLastSymbol()
    {
        if (!string.IsNullOrEmpty(CalculationLine))
        {
            return CalculationLine[CalculationLine.Length - 1];
        }

        return '\0';
    }

    public void DeleteLastSymbol()
    {
        if (!string.IsNullOrEmpty(CalculationLine))
        {
            CalculationLine = CalculationLine.Remove(CalculationLine.Length - 1);
        }
    }
}