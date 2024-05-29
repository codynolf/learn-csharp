namespace learn.fpdeepdive;

public static class TestData {
    public static List<TaxRate> TaxRates => new List<TaxRate>() {
        new TaxRate() {
            State = "CA",
            Rate = 8
        },
        new TaxRate() {
            State = "AZ",
            Rate = 7
        },
        new TaxRate() {
            State = "UT",
            Rate = 5
        },
    };

    public static Order CAOrder => new Order(
        shippingState: "CA",
        orderNumber: 153,
        orderDate: new DateTime(2021, 1, 2),
        customer: new Customer(){
            BillingState = "MA",
        },
        items: new List<OrderItem>() {
            new OrderItem() {
                Quantity = 6,
                Item = new Item() {
                    Name = "Widget",
                    Price = 12,
                    Taxable = true,
                    Options = new ItemOptions() {
                        Cost = 5,
                        Name = "Large"
                    }
                }
            },
            new OrderItem() {
                Quantity = 2,
                Item = new Item() {
                    Name = "Dingbat",
                    Price = 54,
                    Taxable = false,
                    Options = new ItemOptions() {
                        Cost = 9,
                        Name = "Special"
                    }
                }
            }
        }
    );

    public static Order AZOrder => new Order(
        shippingState: "AZ",
        orderNumber: 434,
        orderDate: new DateTime(2021, 2, 5),
        customer: new Customer(){
            BillingState = "MA",
        },
        items: new List<OrderItem>() {
            new OrderItem() {
                Quantity = 2,
                Item = new Item() {
                    Name = "Widget",
                    Price = 12,
                    Taxable = true
                }
            },
            new OrderItem() {
                Quantity = 32,
                Item = new Item() {
                    Name = "Foo",
                    Price = 4,
                    Taxable = true
                }
            },
            new OrderItem() {
                Quantity = 4,
                Item = new Item() {
                    Name = "Bar",
                    Price = 10,
                    Taxable = true
                }
            },
            new OrderItem() {
                Quantity = 2,
                Item = new Item() {
                    Name = "Dingbat",
                    Price = 54,
                    Taxable = false,
                    Options = new ItemOptions() {
                        Cost = 9,
                        Name = "Special"
                    }
                }
            }
        }
    );

    public static Order UTOrder => new Order(
        shippingState: "UT",
        orderNumber: 34,
        orderDate: new DateTime(2020, 11, 20),
        customer: new Customer(){
            BillingState = "MA",
        },
        items: new List<OrderItem>() {
            new OrderItem() {
                Quantity = 120,
                Item = new Item() {
                    Name = "Widget",
                    Price = 12,
                    Taxable = true,
                    Options = new ItemOptions() {
                        Cost = 2,
                        Name = "Special"
                    }
                }
            },
            new OrderItem() {
                Quantity = 300,
                Item = new Item() {
                    Name = "Thing",
                    Price = 2,
                    Taxable = false,
                    Options = new ItemOptions() {
                        Cost = -1,
                        Name = "ScratchDent"
                    }
                }
            }
        }
    );
}