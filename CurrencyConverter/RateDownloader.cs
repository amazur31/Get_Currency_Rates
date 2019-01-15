using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;

namespace CurrencyConverter
{
    public class RateDownloader
    {
        public async void GetCurrencyRate(string currency)
        {
            RootObject data;
            Display display = new Display();

            try
            { 
                using (var httpClient = new HttpClient())
                {
                     string url = $"http://api.nbp.pl/api/exchangerates/rates/a/{currency}/?format=JSON";
                     var json = await httpClient.GetStringAsync(url);
                     data = JsonConvert.DeserializeObject<RootObject>(json);
                     display.DisplayRate(data);
                }
            }
            catch
            {
                display.DisplayError();
            }
        }
    }
}
