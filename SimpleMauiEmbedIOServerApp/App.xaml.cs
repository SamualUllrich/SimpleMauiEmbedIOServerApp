using EmbedIO;
using EmbedIO.WebApi;

namespace SimpleMauiEmbedIOServerApp
{
    public partial class App : Application
    {
        private WebServer _webServer;

        public App()
        {
            InitializeComponent();

            var url = "http://localhost:9696/";
            _webServer = CreateWebServer(url);
            _webServer.RunAsync();

            MainPage = new MainPage();
        }

        private static WebServer CreateWebServer(string url)
        {
            return new WebServer(o => o
                    .WithUrlPrefix(url)
                    .WithMode(HttpListenerMode.EmbedIO))
                .WithWebApi("/api", m => m.WithController<LocationController>());
        }
    }
}