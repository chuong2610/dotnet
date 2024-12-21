internal class Program
{
    private static void Main(string[] args)
    {
          int[] lstNumber = { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };
        int sum = 0;
        for (int i = 0; i < lstNumber.Length; i++)
        {
            sum += lstNumber[i];
        }
        Console.WriteLine("Tổng các số trong mảng là: " + sum);
    }
}