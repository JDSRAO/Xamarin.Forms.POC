using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MyXamlApp
{
    public class BoxViewPage : ContentPage
    {
        public BoxViewPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Frame
                    {
                        OutlineColor = Color.Accent,
                        Padding = new Thickness(5),
                        Content = new StackLayout
                        {
                            Orientation = StackOrientation.Horizontal,
                            Spacing = 15,
                            Children =
                            {
                                new BoxView
                                {
                                    Color = Color.Aqua
                                },
                                new Label
                                {
                                    Text = "Aqua",
                                    FontAttributes = FontAttributes.Bold,
                                    FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))
                                }
                            }
                        }
                    },
                    new Frame
                    {
                        OutlineColor = Color.Accent,
                        Padding = new Thickness(5),
                        Content = new StackLayout
                        {
                            Orientation = StackOrientation.Horizontal,
                            Spacing = 15,
                            Children =
                            {
                                new BoxView
                                {
                                    Color = Color.Blue
                                },
                                new Label
                                {
                                    Text = "Blue",
                                    FontAttributes = FontAttributes.Bold,
                                    FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
