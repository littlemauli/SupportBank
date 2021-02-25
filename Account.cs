using System.Linq;
using System.Collections.Generic;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace SupportBank
{

    public class Account
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
        public string Name {get; set;}

        public List<Transaction> IncomingTransactions {get; set;}

        public List<Transaction> OutgoingTransactions {get; set;}
    }








    // public class SinglePerson
    // { 
    //     public List<SingleTransaction> TransactionsOwed = new List<SingleTransaction>();
    //     public List<SingleTransaction> TransactionsHeOwes = new List<SingleTransaction>();
    //   public string Name{get;set;}
      
    //   public decimal AmountHeOwes => TransactionsHeOwes.Sum(trans => trans.Amount);
    //   public decimal AmountOwed => TransactionsOwed.Sum(trans => trans.Amount);

    //     internal void AddTransactionOwed(SingleTransaction owed)
    //     {
    //         TransactionsOwed.Add(owed);
    //     }

    //     internal void AddTransactionHeOwes(SingleTransaction heowes)
    //     {
    //        TransactionsHeOwes.Add(heowes);
    //     }
    // }



}