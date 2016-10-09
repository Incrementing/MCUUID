using System;
using System.Net;
using Newtonsoft.Json.Linq; //From http://www.newtonsoft.com/json

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.13) Gecko/20080311 Firefox/2.0.0.13");
            string raw = client.DownloadString("https://api.mcuuid.com/json/uuid/notch");
            JObject json = JObject.Parse(raw);
            Console.WriteLine((string)json["uuid"]); //069a79f4-44e9-4726-a5be-fca90e38aaf5
        }
    }
}
