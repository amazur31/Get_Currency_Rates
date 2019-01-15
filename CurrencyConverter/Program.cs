using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;
using System.Threading;
namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false)
            { 
            Console.WriteLine("Enter shortcut for currency (ex. USD)");
            string currency = Console.ReadLine();
            RateDownloader rate = new RateDownloader();
            rate.GetCurrencyRate(currency);
            Thread.Sleep(1000);
            }
        }
    }
}
