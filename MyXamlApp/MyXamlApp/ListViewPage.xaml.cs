using MyXamlApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net;
using MyXamlApp.Dependency_Services;

namespace MyXamlApp
{
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            var networkConnection = DependencyService.Get<INetworkConnection>();
            networkConnection.CheckNetworkConnection();
            var networkStatus = networkConnection.IsConnected ? "Connected" : "Not Connected";
            var alertText = DependencyService.Get<INetworkConnection>().IsConnected ? "You are Connected" : "You are Not Connected";
            if (!DependencyService.Get<INetworkConnection>().IsConnected)
            {
                DisplayAlert("Error", "You are not connected to internet", "Ok");
                DisplayActionSheet("Error", "Cancel", "Destruction", "Button");
                //lstView.ItemsSource = new List<string> {"Sunday", "Monday", "Wednesday" };
                lstView.ItemsSource = new List<PersonDetails>
                {
                    new PersonDetails { Id=1,Name="KJDS",Designation="King" },
                    new PersonDetails { Id=2,Name="CK",Designation="Princess" },
                    new PersonDetails { Id=3,Name="Hinata",Designation="Queen" },
                    new PersonDetails { Id=4,Name="Trump",Designation="President" }
                };
                lstView.ItemSelected += delegate
                {
                    var selectedItem = (PersonDetails)lstView.SelectedItem;
                    DisplayAlert("Selected!", selectedItem.Name, "OK");
                };
            }
            else
            {
                
                string endpointUrl = "http://www.recipepuppy.com/api/";
                //https://developer.xamarin.com/guides/xamarin-forms/web-services/consuming/rest/
                //https://developer.xamarin.com/guides/cross-platform/application_fundamentals/web_services/
            }
        }

        async protected override void OnAppearing()
        {
            if (!DependencyService.Get<INetworkConnection>().IsConnected)
            {
                base.OnAppearing();
                var persons = DataService.GetData();
                var data = await persons;
                lstView.ItemsSource = data.results;
            }
        }

    }
}
