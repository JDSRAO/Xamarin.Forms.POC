using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MyXamlApp
{
    public class ButtonLoggerPage : ContentPage
    {
        StackLayout loggerLayout = new StackLayout();
        public ButtonLoggerPage()
        {
            Button btn = new Button
            {
                Text = "Click me!"
            };
            btn.Clicked += OnBtn_Clicked;

            Content = new StackLayout
            {
                Children =
                {
                    btn,
                    new ScrollView
                    {
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        Content = loggerLayout
                    }
                }
            };
            
        }

        private void OnBtn_Clicked(object sender, EventArgs e)
        {
            loggerLayout.Children.Add(new Label
            {
                Text = "btn clicked at" + DateTime.Now.ToString()
            });
        }
    }
}
