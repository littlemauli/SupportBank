using System;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace SupportBank
{
    public class Transaction
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
        public string FromName { get; set; }
        public string ToName { get; set; }
        public string Narrative { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }


    }

}