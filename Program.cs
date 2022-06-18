using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace parser
{
    class Program
    {
        HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            Program program = new Program();
            await program.parse();
        }
        private async Task parse()
        {
            string from = "https://api.vk.com/method/users.get";
            string response = await client.GetStringAsync("https://api.vk.com/method/users.get?user_id=a.borisov1994&v=5.131");
            Console.WriteLine(response);
        }
    }
}