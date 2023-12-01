using PracovniZadaniV2;

class Program
{
    static void Main(string[] args)
    {
        //Vytvoření listu a položek, který obsahuje jednotlivé položky (itemy) rozvahy s příslušnými hodnotami dle zadání
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

        //Vytvoření objektu "Rozvaha", pro aktuální kód není nezbytně nutné mít třídu BalanceSheet - Mohla by se hodit, pokud bychom chtěli přidávat do kódu další funkcionalitu nebo upravovat strukturu rozvahy
        var balanceSheet = new BalanceSheet(balanceSheetItems);
        var soucet = 0m;

        //Výpis do konzole a cyklus, který procházi položky v rozvaze a v případě, že položka je typu Asset, přičte jeho hodnotu k celkovému součtu, v ostatních případech položky odečte
        Console.WriteLine("Balance Sheet Items in EUR: ");
        foreach (var item in balanceSheet.Items)
        {
            Console.WriteLine($"Item: {item.Name}, Amount in EUR: {item.GetAmountInEUR()}");

            if (item.GetType() == ItemType.Asset.GetType()) soucet += item.Amount;
            else soucet -= item.Amount;
        }
        Console.WriteLine($"Saldo: {soucet}");
    }
}