using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MyXamlApp.Pages
{
    public class ModalPage : ContentPage
    {
        public ModalPage()
        {
            Title = "Title: Modal Page";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Modal Page" }
                }
            };
        }
    }
}
