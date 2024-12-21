internal class Program
{
    private static void Main(string[] args)
    {
         int[] nums = { 1, 1, 2, 2, 3, 4, 4, 5 };
        int length = RemoveDuplicates(nums);
        Console.WriteLine("Mảng sau khi loại bỏ trùng lặp:");
        for (int i = 0; i < length; i++)
            Console.Write(nums[i] + " ");
    }

    static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int index = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[index] = nums[i];
                index++;
            }
        }
        return index;
    }
    
}