using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public class OrderService
    {
        private readonly IEmailService _emailService;
        private readonly IOrderProcessor _orderProcessor;

        public OrderService(IEmailService emailService, IOrderProcessor orderProcessor)
        {
            _emailService = emailService;
            _orderProcessor = orderProcessor;
        }

        public void ProcessOrder(Order order)
        {
            var s = false;

            ("Attempting to process order with ID " + order.Id);
            s = order.Priority switch
            {
                OrderStatus.Normal => _orderProcessor.ProcessOrderNormally(order),
                OrderStatus.Quick => _orderProcessor.ProcessOrderQuickly(order),
                OrderStatus.LightningSpeed => _orderProcessor.ProcessOrderInLigtningSpeed(order),
                _ => false
            };

            switch (s)
            {
                case true:
                    "Successfully processed order with ID " + order.Id;
                    _emailService.SendNotificationEmail(order.Email, order.Id);
                    break;
                case false:
                    "FAILED ORDER: Could not ship order with ID " + order.Id;
                    break;
            }
        }
    }
}
