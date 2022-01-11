using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2.Services
{
    public class EmailService : IEmailService
    {
        public void SendNotificationEmail(string email, Guid id)
        {
            Console.WriteLine($"Notification sent to email {email} for order {id}");
        }
    }
}
