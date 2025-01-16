using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ValueConverter.Model
{
    internal class CurrencyService
    {
        public const string JSON_PATH = "https://www.cbr-xml-daily.ru/daily_json.js";
        public Currency Currency { get; set; }
        public Dictionary<string, Valute> Valutes { get; set; }
        public async Task LoadCurrencyAsync(ListView listview)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(JSON_PATH);

            if (!string.IsNullOrEmpty(response))
            {
                Currency currency = JsonConvert.DeserializeObject<Currency>(response);
                Currency = currency;

                listview.ItemsSource = currency.Valute.Values;
            }
        }
        public ComboBox LoadValutes(ComboBox combobox)
        {
            combobox.ItemsSource = Valutes;
        }
    }
}
