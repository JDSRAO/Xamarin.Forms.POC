using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MyXamlApp
{
    public class FramedTextPage : ContentPage
    {
        public FramedTextPage()
        {
            Padding = new Thickness(20);
            BackgroundColor = Color.Aqua;
            Content = new Frame
            {
                OutlineColor = Color.Black,
                BackgroundColor = Color.Yellow,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Content = new Label
                {
                    Text = "My content",
                    FontSize = Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                    TextColor = Color.Blue
                }
            };
        }
    }
}
