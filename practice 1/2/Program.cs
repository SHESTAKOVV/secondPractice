namespace _2;

public class Program
{
    static void Main(string[] args)
    {
        int[] candidates = new int[] { 2, 5, 2, 1, 2 };
        int target = 5;

        List<List<int>> combinations = CombinationSum(candidates, target);

        foreach (List<int> combination in combinations)
        {
            Console.WriteLine($"Комбинация: {string.Join(", ", combination)}");
        }
    }

    static List<List<int>> CombinationSum(int[] candidates, int target)
    {
        List<List<int>> result = new List<List<int>>();
        Array.Sort(candidates);

        FindCombinations(candidates, target, new List<int>(), result, 0);

        return result;
    }

    static void FindCombinations(int[] candidates, int target, List<int> current, List<List<int>> result, int startIndex)
    {
        if (target == 0)
        {
            result.Add(new List<int>(current)); 
            return;
        }

        for (int i = startIndex; i < candidates.Length; i++)
        {
            if (candidates[i] > target)
            {
                break;
            }

            if (i > startIndex && candidates[i] == candidates[i - 1])
            {
                continue;
            }

            current.Add(candidates[i]); 
            FindCombinations(candidates, target - candidates[i], current, result, i + 1); 
            current.RemoveAt(current.Count - 1);
        }
    }
}
