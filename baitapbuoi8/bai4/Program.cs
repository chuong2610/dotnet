internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = { 1, 1, 1, 2, 2, 3 };
        int k = 2;
        var result = TopKFrequent(nums, k);

        Console.WriteLine("Phần tử xuất hiện nhiều nhất:");
        foreach (var num in result)
            Console.Write(num + " ");
    }
     static IList<int> TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (frequencyMap.ContainsKey(num))
                frequencyMap[num]++;
            else
                frequencyMap[num] = 1;
        }

        return frequencyMap.OrderByDescending(x => x.Value)
                           .Take(k)
                           .Select(x => x.Key)
                           .ToList();
    }
}