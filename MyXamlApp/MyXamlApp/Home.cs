using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MyXamlApp
{
    public class Home : NavigationPage
    {
        public Home() : base(new Index())
        {
            
        }
    }
}
