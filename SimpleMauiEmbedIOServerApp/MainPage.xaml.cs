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
                CounterBtn.Text = $"{response}";
                SemanticScreenReader.Announce(CounterBtn.Text);
            }
        }
    }
}