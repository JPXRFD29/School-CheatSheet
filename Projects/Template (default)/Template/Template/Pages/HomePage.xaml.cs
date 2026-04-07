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
using System.Collections.ObjectModel;
using Template.Data.Models;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Template.Pages
{
    public sealed partial class HomePage : Page
    {
        public ObservableCollection<Movie> Movies { get; set; } = new()
        {
            new Movie { Id = 1, Name = "Mario Movie", Rating = 3.5f },
            new Movie { Id = 2, Name = "Zelda Movie", Rating = 4.5f }
        };
        public HomePage()
        {
            this.InitializeComponent();
            
        }
    }
}
