using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace StockBrokerApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public partial class StockBrowserPage : Page
    {
        public StockBrowserPage()
        {
            this.InitializeComponent();
        }
        
        private void OnFindStock (object sender, RoutedEventArgs e)
        {

        }

        private void OnPurchaseStock (object sender, RoutedEventArgs e)
        {

        }

        private void OnCompleteOrder (object sender, RoutedEventArgs e)
        {

        }
    }

    public class StockExchange : StockBrowserPage
    {
        StockExchange _stockExchange = new StockExchange();

        public void LoadStocks()
        {
            string text = System.IO.File.ReadAllText(@"D:\Shaqeel\Downloads\StockBrokerApp - Start.zip\StockBrokerApp - Start\data samples\StockExchangeData.txt");
        }
    }

    IEnumerable <Stock>;

    public class Stock : StockExchange
    {
        private string symbol;
        private double _price;
        private string _news;

        public string String { get; set; }

        public double Price { get; set; }

        public string News { get; set; }

        public StockType Type { get; set; }

        public double ProjectedValue { get; }

    }

    public enum StockType : Stock
    {
        //Regular
        //BlueChip
        //Index
    }

    public partial class Investment
    {
        public int StockOrderCount { get; }

        public double CurrentValue { get; }

        public double FutureValue { get; }

        public void StockOrderCounting()
        {
            int stockorders = StockOrder<Stock>;
        }
        
        public void Buy(Stock stock, int shares)
        {

        }

        public void SaveOrder()
        {

        }
    }

    IEnumerable<StockOrder>;

    public class StockOrder : Investment
    {
        public int Shares { get; set; }

        public Stock Stock { get; set; }

        public new double CurrentValue { get; }

        public new double FutureValue { get; }

        public void getShares()
        {
            Shares = 10; //gets number of shares;
        }

        public void stockOrdered()
        {
            Stock = true //stock was ordered, returns true
        }

        public void CurrentValue()
        {
            getShares();
        }

        public void FutureValue()
        {
            getShares();
        }

    }
}
