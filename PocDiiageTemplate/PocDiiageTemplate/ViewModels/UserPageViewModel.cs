using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PocDiiageTemplate.ViewModels
{
    public class UserPageViewModel : ViewModelBase
    {
        private string _username;

        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        public UserPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "User Page";
            Username = "Simon Cotelle";
        }
    }
}
