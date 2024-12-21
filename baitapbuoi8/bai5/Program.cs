internal class Program
{
    private static void Main(string[] args)
    {
        
        int[] prices = { 7, 1, 5, 3, 6, 4 };
        int maxProfit = MaxProfit(prices);

        Console.WriteLine("Lợi nhuận lớn nhất: " + maxProfit);
    }
     static int MaxProfit(int[] prices)
    {
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach (int price in prices)
        {
            if (price < minPrice)
                minPrice = price;
            else if (price - minPrice > maxProfit)
                maxProfit = price - minPrice;
        }

        return maxProfit;
    }
}