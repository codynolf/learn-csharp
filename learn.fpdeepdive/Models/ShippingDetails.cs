namespace learn.fpdeepdive;

public class ShippingDetails
{
    public double ShippingCost { get; private set; }
    public DateTime EstimatedArrival { get; private set; }
    public string DestinationState { get; private set; }

    public ShippingDetails(double shippingCost, DateTime estimatedArrival, string destinationState)
    {
        ShippingCost = shippingCost;
        EstimatedArrival = estimatedArrival;
        DestinationState = destinationState;
    }
}
