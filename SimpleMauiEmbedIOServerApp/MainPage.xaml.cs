using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text.Json;

namespace SimpleMauiEmbedIOServerApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClickedAsync(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync("http://localhost:9696/api/location");
                CounterBtn.Text = "Clicked";
                var location = JsonConvert.DeserializeObject<Location>(response);

                LocationInfoLabel.Text = $"Latitude: {location.Latitude}, Longitude: {location.Longitude}";

                SemanticScreenReader.Announce(LocationInfoLabel.Text);
            }
        }
    }
}