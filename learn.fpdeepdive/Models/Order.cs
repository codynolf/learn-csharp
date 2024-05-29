namespace learn.fpdeepdive;

public class Order
{
    public List<OrderItem> Items { get; private set; }
    public Customer Customer { get; private set; }
    public string ShippingState { get; private set; }
    public int OrderNumber { get; private set; }
    public DateTime OrderDate { get; private set; }
    public DateTime EstimatedArrival { get; private set; }
    public double ShippingCost { get; private set; }

    public double Total { get; private set; }

    public Order(List<OrderItem> items,
        Customer customer, 
        string shippingState, 
        int orderNumber, 
        DateTime orderDate, 
        DateTime estimatedArrival = default(DateTime), 
        double shippingCost = 0.0, 
        double total = 0.0)
    {
        Items = items;
        Customer = customer;
        ShippingState = shippingState;
        OrderNumber = orderNumber;
        OrderDate = orderDate;
        EstimatedArrival = estimatedArrival;
        ShippingCost = shippingCost;
        Total = total;
    }
}
