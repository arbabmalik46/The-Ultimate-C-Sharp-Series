using System.IO;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Async
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //DownloadHTML("https://learn.microsoft.com/en-gb/");
            //DownloadHTMLAsync("https://learn.microsoft.com/en-gb/");
            //var stringMessage = GetHTML("https://learn.microsoft.com/en-gb/");

            var html = GetHTMLAsync("https://learn.microsoft.com/en-gb/");
            MessageBox.Show("Loading");
            var stringMessage = await html;
            MessageBox.Show(stringMessage.Substring(0,25));
        }
        public async Task<string> GetHTMLAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }
        public string GetHTML(string url)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }
        public async Task DownloadHTMLAsync(string url)
        {
            var webClient = new WebClient();
            var html =await webClient.DownloadStringTaskAsync(url);
            using (var streamWrite = new StreamWriter("D:\\Practices\\DotNet\\The-Ultimate-C-Sharp-Series\\Async\\WebStream\\Output.txt"))
            {
                await streamWrite.WriteAsync(html);
            }
        }
        public void DownloadHTML(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);
            using (var streamWrite = new StreamWriter("D:\\Practices\\DotNet\\The-Ultimate-C-Sharp-Series\\Async\\WebStream\\Output.txt"))
            {
                streamWrite.Write(html);
            }
        }
    }
}