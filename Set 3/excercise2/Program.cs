using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    //Exercise 2: How would you reduce the responsabilities of paymentProcessor in order to make the system more cohesive?
    class Program
    {
        static async Task Main(string[] args) 
        {
            var paymentProcessor = new PaymentProcessor();
            paymentProcessor.Db = new DBRepository();
            paymentProcessor.EmailSender = new EmailSender();
            paymentProcessor.messageSender = new MessageSender();

            await paymentProcessor.ProcessPayment(1,1500.12); 
        }
    }
}
