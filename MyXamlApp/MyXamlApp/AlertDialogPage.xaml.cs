using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyXamlApp
{
    public partial class AlertDialogPage : ContentPage
    {
        bool result;
        public AlertDialogPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            Task<bool> task = DisplayAlert("Alert","Simple alert","Ok","Cancel");
            task.ContinueWith(AlertDismissedCallback);
            label.Text = "Alert is currently displayed";
        }

        void AlertDismissedCallback(Task<bool> task)
        {
            result = task.Result;
            Device.BeginInvokeOnMainThread(DisplayResultCallback);
        }

        void DisplayResultCallback()
        {
            label.Text = String.Format("Alert {0} button was pressed", result ? "OK" : "Cancel");
        }
    }
}
