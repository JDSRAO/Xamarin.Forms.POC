using MyXamlApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyXamlApp
{
    public class DataService
    {
        const string bookUrl = "http://www.recipepuppy.com/api/";
        
        async public static Task<ReceipeTotalModel> GetData()
        {
            ReceipeTotalModel details = new ReceipeTotalModel();
            try
            {
                HttpClient client = new HttpClient();
                var response = client.GetStringAsync(bookUrl);
                var json = await response;
                details = JsonConvert.DeserializeObject<ReceipeTotalModel>(json);
            }
            catch (Exception)
            {
                throw;
            }
            return details;
        }
    }
}
