using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2.Services
{
    public class OrderProcessorService : IOrderProcessor
    {
        public bool ProcessOrderNormally(Order order)
        {
            // Some logic we don't care about,
            return true;
        }

        public bool ProcessOrderQuickly(Order order)
        {
            // Some logic we don't care about
            return true;
        }

        public bool ProcessOrderLigtningSpeed(Order order)
        {
            // Some logic we don't care about
            return true;
        }
    }
}
