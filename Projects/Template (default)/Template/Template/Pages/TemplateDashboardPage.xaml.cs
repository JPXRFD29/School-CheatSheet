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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TemplateDashboardPage : Page
    {
        public static List<ItemModel> Items = new()
        {
            new ItemModel { Id = 1, Name = "Alice Johnson", Email = "alice@company.com", Role = "Engineer",  Department = "Backend",  Status = "Active"   },
            new ItemModel { Id = 2, Name = "Bob Smith",     Email = "bob@company.com",   Role = "Designer",  Department = "Product",  Status = "Active"   },
            new ItemModel { Id = 3, Name = "Carol White",   Email = "carol@company.com", Role = "Manager",   Department = "HR",       Status = "Inactive" },
            new ItemModel { Id = 4, Name = "David Brown",   Email = "david@company.com", Role = "Analyst",   Department = "Finance",  Status = "Active"   },
            new ItemModel { Id = 5, Name = "Eva Martinez",  Email = "eva@company.com",   Role = "Engineer",  Department = "Frontend", Status = "Inactive" },
        };

        public TemplateDashboardPage()
        {
            this.InitializeComponent();
            ItemsList.ItemsSource = Items;
        }

        private void ItemsList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.ClickedItem is ItemModel item)
                Frame.Navigate(typeof(ItemDetailPage), item);
        }
    }
}
