using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MyXamlApp
{
    public class GreetingsPage : ContentPage
    {
        public GreetingsPage()
        {
            StackLayout stack = new StackLayout();
            stack.Children.Add( new Label {Text = "lbl 1" } );
            Picker pek = new Picker();
            pek.Title = "Sample picker";
            pek.Items.Add("1");
            pek.Items.Add("2");
            pek.Items.Add("3");
            stack.Children.Add(pek);

            Content = new ScrollView
            {
                Content = stack
            };
        }
    }
}
