using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace Coinverter.Client
{
    public class CurrencyConverterClient
    {

        private readonly HttpClient _httpClient;

        private CurrencyConverterClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task <string> GetCurrency()
        {
            using (var response = await _httpClient.GetAsync("https://free.currconv.com/api/v7/convert?q=USD_BRL&compact=y&apiKey=b424d956f5173206e6fb"))
            {
                return await response.Content.ReadAsStringAsync();
            }

            return "";
        }
        
    }
}
