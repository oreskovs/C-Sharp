using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CurrencyRatesFetcher
{
    internal class ExchangeService
    {
        private readonly HttpClient _httpClient;

        public ExchangeService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetRatesAsync(string currency)
        {
            try
            {
                string url = $"https://api.exchangerate.host/latest?base=EUR";

                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();
                ExcangeRates rates = JsonSerializer.Deserialize<ExcangeRates>(json);

                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\nExchange rates for {rates.Base} on {rates.Date}:");

                foreach (var pair in rates.Rates.Take(10))
                {
                    sb.AppendLine($"{pair.Key}: {pair.Value}");
                }

                return sb.ToString();


            }
            catch (Exception err)
            {
                return $"Failed to fetch rates {err.Message}";
            }
        }
    }
}
