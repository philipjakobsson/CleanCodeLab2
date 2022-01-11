using ITHS_CC_Labb2;

var orderService = new OrderService(new EmailService(), new OrderProcessorService());

var slowOrder = new Order
{
    ID = Guid.NewGuid(),
    Email = "slowEmail@example.com",
    Priority = OrderStatus.Normal,
    TotalPrce = 100,
};

orderService.ProcessOrder(slowOrder);