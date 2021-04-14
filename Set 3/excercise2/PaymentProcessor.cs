using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    
    class PaymentProcessor
    {
        public DBRepository Db { get; set; }

        public EmailSender EmailSender { get; set; }

        public MessageSender messageSender { get; set; }

        public async Task ProcessPaymentAsync(int userId, decimal amount)
        {

            var payment = new Payment{
                Date = DateTime.UtcNow,
                UserId = userId,
                Amount = amount
            };
            Db.Store(payment);

            //notify collector
            EmailSender.Send("paymentprocessor@mg-group.com.ar","collector@mg-group.com.ar","Payment processed",$"Payment {payment.Id} processed");

            //delete alerts
            Db.Delete<PendingPaymentAlert>(x => x.UserId == userId);

            //Report to async processor
            await messageSender.SendAsync("PaymentProcessed", payment.Id);            
        }
    }
}
