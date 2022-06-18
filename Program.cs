using Newtonsoft.Json;
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
            string token = "vk1.a.RWs5G9Uzr_jwTVzO9IEB8E0PCNlg50T6xYjrDV_v72AX3MOyDbILlhi2a8D_VJ1H1faaVffvrgoegIiWHSxZeu3ZQeEl0FY-arfMTzSmp40-VS1OH1QxrWz6K-uMcyc9ScDyK8PT91UD8UCGyN1mRT4BzruoWlRGyLK4LMh0Tr1uZosRoHMemofnqCxLKW6z";
            //string owner_id = "-206944280";
            string domain = "imct_fefu";
            int count = 2;
            // + "&count=" + count.ToString()
            string from = "https://api.vk.com/method/";
            string response = await client.GetStringAsync(from + "wall.get?domain=" + domain + "&count=" + count.ToString() + "&access_token=" + token + "&v=5.131");
            //Console.WriteLine(response);
            Parser _response = JsonConvert.DeserializeObject<Parser>(response);
            Console.WriteLine(_response.response.items[0].text);
            
        }
    }
}