using System;


namespace SupportBank
{
    public class SingleTransaction
    {
        public string FromName { get; set; }
        public string ToName { get; set; }
        public string Narrative { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }


    }

}