using System;
using WhaleAlertAPI;

namespace WhaleAlertExample
{
    public class Program
    {
        //Version 1.0.4
        static void Main(string[] args)
        {
            //Create class with the API Key
            WhaleAlert whaleAlert = new WhaleAlert("API Key here");
            //Get request --> Reponse Status Object
            StatusResponse Status = whaleAlert.GetStatus();
            //Error Handling
            if(Status.Success == false)
            {
                Console.WriteLine(Status.Error.Message);
                return;
            }
            //Success 
            Console.WriteLine(Status.Status.Result);

            //Blockchain Count
            Console.WriteLine(Status.Status.BlockchainCount);

            //List of all Blockchains
            foreach (Blockchain entry in Status.Status.Blockchains)
            {
                string symbols = "";
                foreach(string s in entry.Symbols)
                {
                    symbols += s + ",";
                }

                Console.WriteLine($"{entry.Name} [{symbols}]: {entry.Status}");
            }

            Console.WriteLine("\n");
            //Get request --> Reponse Transactions Object
            TransactionsResponse transactionsResponse = whaleAlert.GetTransactions(1550237797);

            //List of Transcations
            int counter = 0;
            foreach(Transactions entry in transactionsResponse.Transactions.Transactions)
            {
                counter++;
                Console.WriteLine($"{counter}. {entry.Symbol}: {entry.Amount}; USD: {entry.AmountUsd}");
            }
        }
    }
}
