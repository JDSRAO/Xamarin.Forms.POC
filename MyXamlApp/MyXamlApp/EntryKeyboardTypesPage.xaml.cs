using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyXamlApp
{
    public partial class EntryKeyboardTypesPage : ContentPage
    {
        public EntryKeyboardTypesPage()
        {
            InitializeComponent();
            datePicker.MaximumDate = DateTime.Now;
            datePicker.Date = DateTime.Now;
        }
    }
}
