using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;

namespace XamarinForms
{
    public class LogInViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        public Action DisplaySuccessfullyLoggedInPromt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public ICommand SubmitCommand { protected set; get; }
        public LogInViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }
        public void OnSubmit()
        {
            if (email != "admin" || password != "1234")
            {
                DisplayInvalidLoginPrompt();
            } else
            {
                DisplaySuccessfullyLoggedInPromt();
            }
        }
    }
}
