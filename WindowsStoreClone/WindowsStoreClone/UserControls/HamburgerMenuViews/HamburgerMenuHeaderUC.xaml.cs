using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowsStoreClone.UserControls.HamburgerMenuViews
{
    /// <summary>
    /// Interaction logic for HamburgerMenuHeaderUC.xaml
    /// </summary>
    public partial class HamburgerMenuHeaderUC : UserControl
    {
        public delegate void OnFilterMenuItemClicked(object sender, RoutedEventArgs e);
        public event OnFilterMenuItemClicked FilterMenuItemClick;

        public delegate void OnSortByMenuItemClicked(object sender, RoutedEventArgs e);
        public event OnSortByMenuItemClicked SortByMenuItemClick;

        public HamburgerMenuHeaderUC()
        {
            InitializeComponent();
        }

        private void Filter_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Forward the event to the parent control
            FilterByTypeLabel.Content = (sender as MenuItem).Header.ToString();
            FilterMenuItemClick(sender, e);
        }

        private void SortBy_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Forward the event to the parent control
            SortByLabel.Content = (sender as MenuItem).Header.ToString();
            SortByMenuItemClick(sender, e);
        }
    }
}
