using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

namespace CSharpAsyncAwait
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

        // Async/Await model for Asynchronous programming - introduced in .NET 4.5
        // await - used inline, before a method call
        //       - signals runtime to wait for the result of an Asyn method 
        //       - many .NET methods that block(take time) execution have Async versions
        //       - can be used only in async methods
        //
        // async - used in method signature
        //       - signals that method will run asynchronously, i.e. caller method will not wait for the called method
        //       - to be run asynchronously at least one await must be used
        //       - returns a Task object that allows the caller to use wait


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DownloadHTML("http://msdn.microsoft.com");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DownloadHtmlAsync("http://msdn.microsoft.com");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var html = GetHtml("http://msdn.microsoft.com");
            MessageBox.Show(html.Substring(0, 10)); 
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var getHtmlTask = GetHtmlAsync("http://msdn.microsoft.com");
            MessageBox.Show("Waiting for get html"); //this blocks execution until you click ok
            var html = await getHtmlTask;
            MessageBox.Show(html.Substring(0, 10));
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }

        public string GetHtml(string url)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }

        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"C:\Users\jaros\source\repos\CSharpAsyncAwait\CSharpAsyncAwait\result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }

        public void DownloadHTML(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"C:\Users\jaros\source\repos\CSharpAsyncAwait\CSharpAsyncAwait\result.html"))
            {
                streamWriter.Write(html);
            }
        }

    }
}
