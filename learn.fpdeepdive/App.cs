namespace learn.fpdeepdive;

public static class App
{
    public static void Run(){
        var taxRates = TestData.TaxRates;
        var order = TestData.CAOrder;

        var orders = new List<Order>() {
            TestData.CAOrder,
            TestData.AZOrder,
            TestData.UTOrder
        };

        Func<List<TaxRate>, string, double> taxRater = (taxRates, state) => taxRates.First(t => t.State == state).Rate;

        var total = OrderService.GetTotal(order, taxRates, taxRater);
        Console.WriteLine($"Order total: ${total}");

        OrderService.UpdateOrderShipDetails(order);

        Console.Read();
    }
}

public interface ILogger {
    public void Log(string message);
}