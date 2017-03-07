using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MyXamlApp
{
    public class TwobuttonPage : ContentPage
    {
        Button Addbutton, RemoveButton;
        StackLayout labelcontent;
        public TwobuttonPage()
        {
            this.CreateLayout();
            this.Content = new StackLayout
            {
                Children =
                {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            Addbutton,
                    RemoveButton,
                        }
                    },
                    new ScrollView
                    {
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        Content = labelcontent
                    }
                }
            };
        }

        private void CreateLayout()
        {
            this.Padding = new Thickness(5, Device.OnPlatform(10, 0, 0), 0, 0);
            Addbutton = new Button
            {
                Text = "Add label",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            Addbutton.Clicked += OnButton_Clicked;
            RemoveButton = new Button
            {
                Text = "Add label",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            RemoveButton.Clicked += OnButton_Clicked;
            RemoveButton.IsEnabled = labelcontent.Children.Count > 0;
        }

        private void OnButton_Clicked(object sender, EventArgs e)
        {
            RemoveButton.IsEnabled = labelcontent.Children.Count > 0;
            Button btn = (Button)sender;
            if (btn == Addbutton)
            {
                labelcontent.Children.Add(new Label
                {
                    Text = ""
                });
            }
            else
            {
                labelcontent.Children.RemoveAt(0);
            }
        }
    }
}
