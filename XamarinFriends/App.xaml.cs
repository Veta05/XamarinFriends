using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFriends.Views;

namespace XamarinFriends
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new FriendsListPage());
        }
    }
}
