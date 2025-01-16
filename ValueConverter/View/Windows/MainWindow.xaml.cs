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
        private Currency _currency;
        private CurrencyService _currencyService;
        public MainWindow()
        {
            InitializeComponent();
            _currencyService = new CurrencyService();
        }

        

        private void InputCurrencyCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void OutputCurrencyCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void RefreshBtn_Click(object sender, RoutedEventArgs e)
        {
            await _currencyService.LoadCurrencyAsync(CurrencyLV);
            _currencyService.LoadValutes(InputCurrencyCmb);
            _currencyService.LoadValutes(OutputCurrencyCmb);
        }

        private void ConvertBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
