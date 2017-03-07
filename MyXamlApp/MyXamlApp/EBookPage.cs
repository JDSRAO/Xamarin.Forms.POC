using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MyXamlApp
{
    public class EBookPage : ContentPage
    {
        public EBookPage()
        {
            StackLayout mainStack = new StackLayout();
            StackLayout textStack = new StackLayout
            {
                Padding = new Thickness(5),
                Spacing = 10
            };
            Assembly assembly = GetType().GetTypeInfo().Assembly;
            string resource = "MyXamlApp.Assest.AboutAssets.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resource))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    bool gotTitle = false;
                    string line;
                    while (null != (line = reader.ReadLine()))
                    {
                        Label label = new Label
                        {
                            Text = line, // Black text for ebooks! TextColor = Color.Black
                        };
                        if(!gotTitle)
                        {
                            label.HorizontalOptions = LayoutOptions.Center;
                            label.FontSize = Device.GetNamedSize(NamedSize.Medium, label);
                            label.FontAttributes = FontAttributes.Bold;
                            mainStack.Children.Add(label);
                            gotTitle = true;
                        }
                        else
                        {
                            textStack.Children.Add(label);
                        }
                    }
                }
            }
            ScrollView scrollView = new ScrollView
            {
                Content = textStack,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Padding = new Thickness(5, 0)
            };

            mainStack.Children.Add(scrollView);
            Content = mainStack;
            BackgroundColor = Color.White;
            // Add some iOS padding for the page. 
            Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0);
        }
    }
}
