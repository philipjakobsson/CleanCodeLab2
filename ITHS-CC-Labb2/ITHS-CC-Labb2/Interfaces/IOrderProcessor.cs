using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2.Interfaces
{
    public interface IOrderProcessor
    {
        bool ProcessOrderNormally(Order order);
        bool ProcessOrderQuickly(Order order);
        bool ProcessOrderInLigtningSpeed(Order order);
    }
}
