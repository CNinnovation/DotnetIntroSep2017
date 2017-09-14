using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsyncPatternsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // AsyncPatternSampleASync();  // ab .NET 1.0
            // AsyncEventPattern();  // ab .NET 2.0
            TaskBasedAsyncPattern(); // ab C# 5.0
            Console.WriteLine("finished");
            Console.ReadLine();
        }

        private static async void TaskBasedAsyncPattern()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://www.microsoft.com");
            // thread in sync context
            string content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);
        }

        private static void AsyncEventPattern()
        {
            WebClient client = new WebClient();
            // string result = client.DownloadString("http://www.microsoft.com"); // sync
            client.DownloadStringCompleted += (sender, e) =>
            {
                string result = e.Result;
                Console.WriteLine(result);  // if synchronization context, event handler im sync context
            };
            client.DownloadStringAsync(new Uri("http://www.microsoft.com"));
            // client.DownloadStringTaskAsync()

        }

        static void AsyncPatternSampleSync()
        {
            HttpWebRequest req = WebRequest.Create("http://www.microsoft.com") as HttpWebRequest;
            WebResponse response = req.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
        }

        static void AsyncPatternSampleASync()
        {
            HttpWebRequest req = WebRequest.Create("http://www.microsoft.com") as HttpWebRequest;
            req.BeginGetResponse(ar =>
            {
                WebResponse response = req.EndGetResponse(ar);
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                string content = reader.ReadToEnd();
                Console.WriteLine(content);  // need to switch to UI Thread
            }, null);


        }
    }
}
