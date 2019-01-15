using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public sealed class Display
    {

        private static Display m_oInstance = null;
        private static readonly object m_oPadLock = new object();
        private int m_nCounter = 0;

        public static Display Instance
        {
            get
            {
                lock (m_oPadLock)
                {
                    if (m_oInstance == null)
                    {
                        m_oInstance = new Display();
                    }
                    return m_oInstance;
                }
            }
        }

        public void DisplayRate(RootObject rate)
        {
            Console.WriteLine("Currency: " + rate.currency);
            Console.WriteLine("Rate: " + rate.rates[0].mid);

        }

        public void DisplayError()
        {
            Console.WriteLine("Currency not found, try again");
        }

        private Display()
        {
            m_nCounter = 1;
        }
    }
}

