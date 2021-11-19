using Coinverter.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coinverter.BO
{
    public class CurrencyBo
    {
        private readonly CurrencyConverterClient _currencyConverterClient;

        public CurrencyBo(CurrencyConverterClient currencyConverterClient)
        {
            _currencyConverterClient = currencyConverterClient;
        }


        public async Task<string> GetCurrencyAsync(string from, string to)
        {
            if (!IsRequestValid(from, to))
                throw new Exception("Request is invalid");

            return await _currencyConverterClient.GetCurrency(from, to);
        }

        private bool IsRequestValid(string from, string to)
        {
            if (from == default || to == default)
                return false;

            return true;
        }
    }
}
