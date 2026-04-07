using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Template.Data;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Template.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UserNameBox.Text;
            string password = PasswordBox.Password;

            if (UserSession.AuthenticateUser(username, password, out var authenticatedUser))
            {
                UserSession.ClearSession();
                UserSession.SetSession(authenticatedUser);
                Frame.Navigate(typeof(HomePage));
            }
            else
            {
                ErrorBox.Text = "Gebruikersnaam of wachtwoord incorrect...";
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof(RegisterPage));
        }
    }
}
