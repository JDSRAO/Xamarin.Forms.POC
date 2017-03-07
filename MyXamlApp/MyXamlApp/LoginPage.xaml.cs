using MyXamlApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyXamlApp
{
    public partial class LoginPage : ContentPage
    {
        LoginPageViewModel viewModel;
        public LoginPage()
        {
            InitializeComponent();
            Login.Clicked += Login_Clicked;
            RememberMe.Items.Add("Yes");
            RememberMe.Items.Add("No");
        }

        private void Login_Clicked(object sender, EventArgs e)
        { 
            DisplayAlert("Under Progess", "Come back later page under construction", "Ok");
        }
    }
}
