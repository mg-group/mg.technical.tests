using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    //Exercise 1: We want to be able to test this program without sending actual emails during the tests, how would you accomplish that? 
    class Program
    {
        static void Main(string[] args) 
        {
            try
            {
                Random businessLogic = new Random();
                var output = businessLogic.Next(1, 1000000);

                EmailSender.Send("mailer@mg-group.com.ar", "testuser@mg-group.com.ar", "Random number generated", output.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.Read();
        }
    }
}
