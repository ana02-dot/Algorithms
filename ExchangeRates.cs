using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Algorithms
{
    class ExchangeRates
    {
        private static readonly string ApiUrl = "http://api.currencylayer.com/";
        private static readonly HttpClient client = new HttpClient();

        public static async Task<decimal> ConvertCurrencyAsync(string fromCurrency, string toCurrency, decimal amount)
        {
            try
            {

                string apiKey = "b99973d7db8909fc842d16b9affe76e0";
                var response = await client.GetStringAsync($"{ApiUrl}live?access_key={apiKey}&currencies={toCurrency}&source={fromCurrency}&format=1");
                var exchangeRates = JObject.Parse(response);

                decimal rate = exchangeRates["quotes"][$"{fromCurrency}{toCurrency}"].Value<decimal>();

                return amount * rate;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching exchange rate: {ex.Message}");
                return 0;
            }
        }
    }
}
