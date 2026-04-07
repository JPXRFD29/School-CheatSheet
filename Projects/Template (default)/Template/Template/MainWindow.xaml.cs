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
using Template.Pages;
using Microsoft.UI.Xaml.Media.Animation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Template
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            ContentFrame.Navigating += ContentFrame_Navigating;

            ContentFrame.Navigate(typeof(LoginPage));
            HideHeader();
        }

        private void ContentFrame_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            if (e.SourcePageType == typeof(LoginPage))
            {
                // Remove header
                HideHeader();
                return;
            }

            // Restore header
            ShowHeader();
        }

        public void ShowHeader()
        {
            HeaderContent.Visibility = Visibility.Visible;

            var storyboard = new Storyboard();
            var animation = new DoubleAnimation
            {
                From = -50,  // start above
                To = 0,      // slide down to normal position
                Duration = TimeSpan.FromMilliseconds(300),
                EasingFunction = new CubicEase { EasingMode = EasingMode.EaseOut }
            };

            Storyboard.SetTarget(animation, HeaderTransform);
            Storyboard.SetTargetProperty(animation, "Y");
            storyboard.Children.Add(animation);
            storyboard.Begin();

            Grid.SetRow(ContentFrame, 1);
            Grid.SetRowSpan(ContentFrame, 1);
        }

        public void HideHeader()
        {
            var storyboard = new Storyboard();
            var animation = new DoubleAnimation
            {
                From = 0,
                To = -50,    // slide up out of view
                Duration = TimeSpan.FromMilliseconds(200),
                EasingFunction = new CubicEase { EasingMode = EasingMode.EaseIn }
            };

            Storyboard.SetTarget(animation, HeaderTransform);
            Storyboard.SetTargetProperty(animation, "Y");
            storyboard.Children.Add(animation);

            storyboard.Completed += (s, e) => HeaderContent.Visibility = Visibility.Collapsed;
            storyboard.Begin();

            Grid.SetRow(ContentFrame, 0);
            Grid.SetRowSpan(ContentFrame, 2);
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(LoginPage));
        }
    }
}