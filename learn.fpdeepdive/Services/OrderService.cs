namespace learn.fpdeepdive;

public static class OrderService {
    public static double GetTotal(Order order, List<TaxRate> TaxRates, Func<List<TaxRate>, string, double> taxRater){
        var total = 0.0;

        double subTotal(OrderItem item) => item.Item.Price * item.Quantity;

        foreach (var item in order.Items) {
           if(item.Item.Taxable){
                var taxRate = taxRater(TaxRates, order.ShippingState);
                total += subTotal(item) * (1 + taxRate);
           }
           else {
                total += subTotal(item);
           }
        }
        return total;
    }

    public static Order UpdateOrderShipDetails(Order order){
        var shipDetails = ShippingService.GetDetails(order);
        return new Order(
            customer: order.Customer, 
            shippingState: order.ShippingState, 
            orderNumber: order.OrderNumber, 
            orderDate: order.OrderDate, 
            estimatedArrival: shipDetails.EstimatedArrival, 
            shippingCost: shipDetails.ShippingCost, 
            total: order.Total)

    }


}