using System;
using NLog;
using NLog.Config;
using NLog.Targets;
using Newtonsoft.Json;

namespace SupportBank
{
    public class Transaction
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
        [JsonProperty(PropertyName="FromAccount")]
        public string FromName { get; set; }
        [JsonProperty(PropertyName="ToAccount")]
        public string ToName { get; set; }
        public string Narrative { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }


    }

}