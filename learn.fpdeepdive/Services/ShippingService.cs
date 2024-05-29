namespace learn.fpdeepdive;

public static class ShippingService
{
    public static ShippingDetails GetDetails(Order order)
    {
        return new ShippingDetails(
            shippingCost: 12.20,
            estimatedArrival: DateTime.Now.AddDays(3),
            destinationState: order.ShippingState
        );
    }
}
