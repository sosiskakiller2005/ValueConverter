using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ValueConverter.Model;
using static System.Net.WebRequestMethods;

namespace ValueConverter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string JSON_PATH = "https://www.cbr-xml-daily.ru/daily_json.js";
        public MainWindow()
        {
            InitializeComponent();
            LoadCurrencyAsync();
        }

        async Task LoadCurrencyAsync()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(JSON_PATH);

            if (!string.IsNullOrEmpty(response))
            {
                Currency currency = JsonConvert.DeserializeObject<Currency>(response);

                CurrencyLV.ItemsSource = currency.Valute.Values;
            }
        } 
    }
}
