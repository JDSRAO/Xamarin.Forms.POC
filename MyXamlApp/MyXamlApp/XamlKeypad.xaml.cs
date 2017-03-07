using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyXamlApp
{
    public partial class XamlKeypad : ContentPage
    {
        App app = Application.Current as App;
        public XamlKeypad()
        {
            InitializeComponent();
            Result.Clicked += Result_Clicked;
            lbl_result.Text = "O";
        }

        private void Result_Clicked(object sender, EventArgs e)
        {
            NavigationPage main = new NavigationPage(new XamlClock());
            //Navigation.PushModalAsync(main);
            Navigation.PushModalAsync(new XamlClock());
        }

        private void OnButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new NavigationPage(new XamlClock()));
        }
    }
}
