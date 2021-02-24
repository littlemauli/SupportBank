using System;
using System.Linq;
using System.IO;
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

            var allTransactions = new List<SingleTransaction>();


            var persons = new Dictionary<string, SinglePerson>();

            var readText = File.ReadAllLines(path).Skip(1);
            foreach (string line in readText)
            {
                var values = line.Split(',');

                var transaction = new SingleTransaction
                {
                    FromName = values[1],
                    ToName = values[2],
                    Narrative = values[3],
                    Amount = Convert.ToDecimal(values[4]),
                    Date = DateTime.Parse(values[0])
                };
                allTransactions.Add(transaction);

                SinglePerson person;

                // if (!persons.TryGetValue(transaction.FromName,out person))//does not exsist in dictionary)
                //    {
                //        person= new SinglePerson{ Name= transaction.FromName };
                //        persons.Add(transaction.FromName, person);
                // }

                if (!persons.ContainsKey(transaction.FromName))
                {
                    person = new SinglePerson { Name = transaction.FromName };
                    persons.Add(transaction.FromName, person);
                }
                else
                {
                    person = persons[transaction.FromName];
                }

                person.AddTransactionOwed(transaction);

                 if (!persons.ContainsKey(transaction.ToName))
                {
                    person = new SinglePerson { Name = transaction.ToName };
                    persons.Add(transaction.ToName, person);
                }
                else
                {
                    person = persons[transaction.ToName];
                }

                person.AddTransactionHeOwes(transaction);



                // if (Transaction.FromName == "Jon A")
                // {
                //     Amountowed.Add(Transaction.Amount);
                // }

                //  foreach (decimal i in Amountowed)
                //  {
                //     Console.WriteLine(i.ToString());
                //  }

            }
            //  decimal Totalowed = Amountowed.Sum();
            //  Console.WriteLine(Totalowed);
        }
    }
}

