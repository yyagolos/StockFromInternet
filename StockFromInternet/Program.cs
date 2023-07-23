
using StockFromInternet;

class Program
{
     static void Main(string[] args)
    {
        StockExchange StockExchange = new StockExchange();
        StockExchange.PriceChangeHandler = ShowPrice;
        StockExchange.Start();
    }
    public static void ShowPrice(int Price) => Console.WriteLine($"New price is:{Price}");
}