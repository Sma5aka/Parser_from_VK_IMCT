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

            Table_class out_table = new Table_class();
            out_table.name_table = "Statistic";

            var parsed = await program.parse();

            string path = @"B:\VK\analys\result.csv";
            if (!File.Exists(path))
            { 
                using (StreamWriter streamWriter = File.CreateText(path))
                {
                    streamWriter.WriteLine(out_table.name_table);
                    streamWriter.WriteLine("Likes;Comments;Views;");

                    for (int i = 0; i < parsed.response.items.Length; i++)
                    {
                        streamWriter.WriteLine(parsed.response.items[i].likes.count.ToString()+
                            ";"+parsed.response.items[i].comments.count.ToString()+";"+
                            parsed.response.items[i].views.count.ToString()+";");
                    }
                }

            } else
            {
                File.Delete(path);
                using (StreamWriter streamWriter = File.CreateText(path))
                {
                    streamWriter.WriteLine(out_table.name_table);
                    streamWriter.WriteLine("Likes;Comments;Views;");

                    for (int i = 0; i < parsed.response.items.Length; i++)
                    {
                        streamWriter.WriteLine(parsed.response.items[i].likes.count.ToString() +
                            ";" + parsed.response.items[i].comments.count.ToString() + ";" +
                            parsed.response.items[i].views.count.ToString() + ";");
                    }
                }
            }

        }
        private async Task<Parser> parse()
        {
            string token = "some_token";
            
            string domain = "imct_fefu";
            int count = 100;
            int offset = 0;

            string from = "https://api.vk.com/method/";
            string response = await client.GetStringAsync(from + "wall.get?domain=" + domain + "&count=" + count.ToString() + "&access_token=" + token + "&v=5.131");

            Parser _response = JsonConvert.DeserializeObject<Parser>(response);

            return _response;
            
        }
    }
}