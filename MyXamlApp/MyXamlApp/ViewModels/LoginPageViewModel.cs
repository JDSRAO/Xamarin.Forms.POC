using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyXamlApp.ViewModels
{
    public class LoginPageViewModel : INotifyPropertyChanged
    {
        string username, password;
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand LoginCommand { private set; get; }
        public string Username
        {
            set
            {
                if (username != value)
                {
                    username = value;
                    OnPropertyChanged();
                }
            }
            get
            {
                return username;
            }
        }
        public string Password
        {
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged();
                }
            }
            get
            {
                return password;
            }
        }

        public LoginPageViewModel()
        {
            LoginCommand = new Command(
                execute:() =>
                {
                    string username = Username;
                    string passw = Password;
                },
                canExecute: () =>
                {
                    return true;
                });
            ICommand example = new Command(execute: (ExecuteLoginApi));
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void ExecuteLoginApi() { }



    }
}
