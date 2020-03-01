using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cw1
{
    class Program
    {
        public static async Task Main(string[] args)
        { 
            //zadanie 2
            var httpClient = new HttpClient();
            var result = await httpClient.GetAsync("https://www.pja.edu.pl");

            if (result.IsSuccessStatusCode)
            {
                string html = await result.Content.ReadAsStringAsync();
                var regex = new Regex("[a-z]+[a-z0-9]*@[a-z0-9]+\\.[a-z]+\\.[a-z]+",
                                      RegexOptions.IgnoreCase);

                MatchCollection matches = regex.Matches(html);
                foreach(var m in matches)
                {
                    Console.WriteLine(m.ToString());
                }
            }
            
            //JS promise async/await
            //JAVA Future
            //C# Task async/await

            Console.WriteLine("Koniec!");
        }
    }
}
