using System;

namespace Cw1
{
    class Program
    {
        public static async Task Main(string[] args)
        { 
            //zadanie 2
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(AssemblyLoadEventArgs[0]);
        }
    }
}
