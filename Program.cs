using System;
using System.Linq;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;

namespace SupportBank
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\training\SupportBank\support-bank-resources-master\Transactions2014.csv";

            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                string[] createText = { "Hello", "And", "Welcome" };
                File.WriteAllLines(path, createText);
            }

            List<decimal>Amountowed = new List<decimal>();
           
            // Open the file to read from.
             var readText = File.ReadAllLines(path).Skip(1);
            foreach (string line in readText)
            {
                
                var values = line.Split(',');

            //    foreach(string el in values){
            //        Console.WriteLine(el);
            //    }

                var Transaction = new SingleTransaction{
                 FromName =values[1],
                 ToName =values[2],
                 Narrative=values[3],
                 Amount = Convert.ToDecimal(values[4]),
                 Date = DateTime.Parse(values[0])
                };
               
               if(Transaction.FromName == "Jon A"){
                   Amountowed.Add(Transaction.Amount);
               }
                var JonA =new SinglePersonListAccount {



                 
               }
                            
            }
       SinglePersonListAccount.TotalAmountOwed(Amountowed); 
    }
     

    }
    

    public class SingleTransaction
    {
        public string FromName { get ; set; }
         public string ToName { get ; set; }
        public string Narrative {get ; set;}
        public decimal Amount {get;set;}
        public DateTime Date{get;set;}
   
   
    }

    public class SinglePersonListAccount
    {
      public string Narrative {get ; set;}
      public decimal AmountHeOwes{get ; set;}
      public DateTime Date{get;set;}
      public decimal AmountOwed{get ; set;}

      public void TotalAmountOwed(List<decimal> Amountowed){

         foreach(decimal i in Amountowed){
            Console.WriteLine(i.ToString());
             }
              decimal Totalowed =Amountowed.Sum();
             Console.WriteLine(Totalowed);
        }


      TotalAmountHeOwes

    }


}

