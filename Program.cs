using PracovniZadaniV2;

class Program
{
    static void Main(string[] args)
    {

        var balanceSheetItems = new List<BalanceSheetItem>
        {
            new BalanceSheetItem
            {
                Name = "Item1",
                Amount = 100,
                Type = ItemType.Asset,
                ConversionStrategy = new AssetConversionStrategy()
            },
            new BalanceSheetItem
            {
                Name = "Item2",
                Amount = -20,
                Type = ItemType.Equity,
                ConversionStrategy = new EquityConversionStrategy()
            },
            new BalanceSheetItem
            {
                Name = "Item3",
                Amount = -30,
                Type = ItemType.PL,
                ConversionStrategy = new PLConversionStrategy()
            },
            new BalanceSheetItem
            {
                Name = "Item4",
                Amount = -50,
                Type = ItemType.Liability,
                ConversionStrategy = new LiabilityConversionStrategy()
            }
        };

        var balanceSheet = new BalanceSheet(balanceSheetItems);

        Console.WriteLine("Balance Sheet Items in EUR: ");
        foreach (var item in balanceSheetItems)
        {
            Console.WriteLine($"Item: {item.Name}, Amount in EUR: {item.GetAmountInEUR()}");
        }
    }
}