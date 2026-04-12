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
using Microsoft.UI;
using Template.Data.Models;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Template.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ItemDetailPage : Page
    {
        private ItemModel _item;

        public ItemDetailPage() => InitializeComponent();

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _item = e.Parameter as ItemModel;
            LoadFields();
        }

        private void LoadFields()
        {
            IdText.Text = _item.Id.ToString();
            NameBox.Text = _item.Name;
            EmailBox.Text = _item.Email;
            RoleBox.Text = _item.Role;
            DepartmentBox.Text = _item.Department;
            StatusCombo.SelectedIndex = _item.Status == "Active" ? 0 : 1;

            SetEditing(false);
        }

        private void SetEditing(bool editing)
        {
            foreach (var box in new[] { NameBox, EmailBox, RoleBox, DepartmentBox })
            {
                box.IsReadOnly = !editing;
                box.BorderThickness = editing ? new Thickness(1) : new Thickness(0);
                box.Background = editing
                    ? new SolidColorBrush(Colors.White)
                    : new SolidColorBrush(Colors.Transparent);
            }

            StatusCombo.IsEnabled = editing;
            EditButton.Visibility = editing ? Visibility.Collapsed : Visibility.Visible;
            SaveButton.Visibility = editing ? Visibility.Visible : Visibility.Collapsed;
            CancelButton.Visibility = editing ? Visibility.Visible : Visibility.Collapsed;
            DeleteButton.IsEnabled = !editing;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e) => SetEditing(true);
        private void CancelButton_Click(object sender, RoutedEventArgs e) => LoadFields();

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            _item.Name = NameBox.Text;
            _item.Email = EmailBox.Text;
            _item.Role = RoleBox.Text;
            _item.Department = DepartmentBox.Text;
            _item.Status = (StatusCombo.SelectedItem as ComboBoxItem)?.Content?.ToString();

            SetEditing(false);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            DeleteConfirm.Visibility = Visibility.Visible;
            ActionBar.Visibility = Visibility.Collapsed;
        }

        private void ConfirmDelete_Click(object sender, RoutedEventArgs e)
        {
            TemplateDashboardPage.Items.Remove(_item);
            Frame.GoBack();
        }

        private void CancelDelete_Click(object sender, RoutedEventArgs e)
        {
            DeleteConfirm.Visibility = Visibility.Collapsed;
            ActionBar.Visibility = Visibility.Visible;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) => Frame.GoBack();
    }
}
