using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyXamlApp
{
    public partial class XamlClock : ContentPage
    {
        public XamlClock()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
        }

        private bool OnTimerTick()
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("T");
            lblDate.Text = dt.ToString("D");
            return true;
        }
    }
}
