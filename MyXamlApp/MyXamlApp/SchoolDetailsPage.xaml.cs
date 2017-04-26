using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyXamlApp
{
    public partial class SchoolDetailsPage : ContentPage
    {
        public SchoolDetailsPage()
        {
            InitializeComponent();
            NavigationPage.SetTitleIcon(this, "icon.png");

            List<Models.PersonDetails> details = new List<Models.PersonDetails>
            {
                new Models.PersonDetails { Id = 1 , Name = "Roy Mustang" , Designation = "Lt. Genaral" },
                new Models.PersonDetails { Id = 2 , Name = "Mustang" , Designation = "Lt. Colonol" },
                new Models.PersonDetails { Id = 3 , Name = "Ford Mustang" , Designation = "Lt." },
                new Models.PersonDetails { Id = 4 , Name = "Camaro Mustang" , Designation = "1st Lt." },
                new Models.PersonDetails { Id = 5 , Name = "Edward Mustang" , Designation = "2nd Lt." }
            };

            lstview.ItemsSource = details;
            lstview.ItemSelected += Lstview_ItemSelected;
        }

        private void Lstview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Models.PersonDetails selectedPerson = (Models.PersonDetails)sender;
            DisplayAlert("Item Selected", selectedPerson.Name, "ok");
        }
    }
}
