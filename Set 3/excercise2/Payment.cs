using System;

namespace Ex
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
    }
}
