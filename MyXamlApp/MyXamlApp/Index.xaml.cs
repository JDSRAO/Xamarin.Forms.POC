using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyXamlApp
{
    public partial class Index : ContentPage
    {
        public Index()
        {
            InitializeComponent();
        }


        void OnIndexClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string className = button.StyleId;
            string namespaceName = "MyXamlApp";
            var classObj = Activator.CreateInstance(Type.GetType(namespaceName + "." + className));
            //Navigation.PushModalAsync((ContentPage)classObj);
            Navigation.PushAsync((ContentPage)classObj);
        }
        //async void OnIndexClicked(object sender, EventArgs e)
        //{
        //    var button = (Button)sender;
        //    string className = button.StyleId;
        //    string namespaceName = "MyXamlApp";
        //    var classObj = Activator.CreateInstance(Type.GetType(namespaceName + "." + className));
        //    await Navigation.PushAsync((ContentPage)classObj);
        //}
    }
}
