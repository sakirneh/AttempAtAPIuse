using System;
using System.Net;
using System.Web;
using System.Net.Http;
using Newtonsoft.Json;


namespace APIuseTest
{
    public partial class CurrencyPriceCheck : Form
    {
        public CurrencyPriceCheck()
        {
            InitializeComponent();

        }

        private async void findPriceBTN_Click(object sender, EventArgs e)
        {
            txtbox.Clear(); // clears the previous text from the loop to avoid clutter.
            HttpClient client = new HttpClient(); // creates a new Http client to allow program to make calls and reviece data.
            HttpResponseMessage response = await client.GetAsync("https://marketdata.tradermade.com/api/v1/live?currency=GBPUSD,EURUSD,GBPCNY,GBPJPY,GBPETH&api_key=6a9-IgOHvyU0YzvJyIL4"); //GBP to USD, EUR to USD, GBP to CNY, GBP to JPY, GBP to ETH
            response.EnsureSuccessStatusCode(); // checks if the call was successful.
            var responseBody = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<CurrencyDetails>(responseBody);


            foreach (var item in result.quotes)
            {
                
                //Console.WriteLine($" Result: {item.base_currency} / {item.quote_currency} {item.mid}");
                
                this.txtbox.Text += $" Result: {item.base_currency} / {item.quote_currency} {item.mid}" + Environment.NewLine; // loops over every item in the converted results and prints them out depending on the currency details.

            }

            
        }

        public class CurrencyDetails
        {

            public string? endpoint { get; set; }
            public Quotes[]? quotes { get; set; }
            public string? requested_time { get; set; }
            public long? timestamp { get; set; }

        }

        public class Quotes
        {

            public double? ask { get; set; }
            public double? bid { get; set; }
            public string? base_currency { get; set; }
            public double? mid { get; set; }
            public string? quote_currency { get; set; }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
