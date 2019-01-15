using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class Display
    {
        public void DisplayRate(RootObject rate)
        {
            Console.WriteLine("Currency: " + rate.currency);
            Console.WriteLine("Rate: " + rate.rates[0].mid);

        }

        public void DisplayError()
        {
            Console.WriteLine("Currency not found, try again");
        }
    }
}
