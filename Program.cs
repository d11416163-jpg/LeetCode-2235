

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        int result1 = solution.Sum(12, 5);
        Console.WriteLine(result1);  // 輸出: 17

        int result2 = solution.Sum(-10, 4);
        Console.WriteLine(result2);  // 輸出: -6
    }
}

