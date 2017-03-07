using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyXamlApp.Models
{
    public class ReceipeTotalModel
    {
        public string title { get; set; }
        public string version { get; set; }
        public string href { get; set; }
        public List<RecipeModel> results { get; set; }
    }
}
