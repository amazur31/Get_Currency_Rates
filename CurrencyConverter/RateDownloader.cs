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
        public async Task GetCurrencyRate(string currency)
        {
            RootObject data;

            try
            { 
                using (var httpClient = new HttpClient())
                {
                     string url = $"http://api.nbp.pl/api/exchangerates/rates/a/{currency}/?format=JSON";
                     var json = await httpClient.GetStringAsync(url);
                     data = JsonConvert.DeserializeObject<RootObject>(json);
                    Display.Instance.DisplayRate(data);
                }
            }
            catch
            {
                Display.Instance.DisplayError();

            }
        }
    }
}
