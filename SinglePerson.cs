using System.Linq;
using System.Collections.Generic;

namespace SupportBank
{

    public class SinglePerson
    { 
        List<SingleTransaction> TransactionsOwed = new List<SingleTransaction>();
        List<SingleTransaction> TransactionsHeOwes = new List<SingleTransaction>();
      public string Name{get;set;}
      
      public decimal AmountHeOwes => TransactionsHeOwes.Sum(trans => trans.Amount);
      public decimal AmountOwed => TransactionsOwed.Sum(trans => trans.Amount);

        internal void AddTransactionOwed(SingleTransaction owed)
        {
            TransactionsOwed.Add(owed);
        }

        internal void AddTransactionHeOwes(SingleTransaction heowes)
        {
           TransactionsHeOwes.Add(heowes);
        }
    }



}