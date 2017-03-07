using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MyXamlApp.Pages
{
    public class ModelessPage : ContentPage
    {
        public ModelessPage()
        {
            Title = "Title: Modeless Page";
            NavigationPage.SetHasBackButton(this, false);
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Modeless Page" }
                }
            };
        }
    }
}
