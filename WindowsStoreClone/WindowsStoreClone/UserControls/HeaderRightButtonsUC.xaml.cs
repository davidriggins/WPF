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

namespace WindowsStoreClone.UserControls
{
    /// <summary>
    /// Interaction logic for HeaderRightButtonsUC.xaml
    /// </summary>
    public partial class HeaderRightButtonsUC : UserControl
    {
        public delegate void OnDownloadButtonClic(object sender, RoutedEventArgs e);
        public event OnDownloadButtonClic HeaderRightButtonsDownloadButtonClick;


        public HeaderRightButtonsUC()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Visibility = Visibility.Collapsed;
            SearchTextBox.Visibility = Visibility.Visible;
        }

        public void MouseDown_OutsideOfHeaderRightButtons(object sender, MouseButtonEventArgs e)
        {
            if (!SearchTextBox.IsMouseOver)
            {
                SearchTextBox.Visibility = Visibility.Collapsed;
                SearchButton.Visibility = Visibility.Visible;
            }
        }

        private void DownloadButton_Click(object sender, RoutedEventArgs e)
        {
            HeaderRightButtonsDownloadButtonClick(sender, e);
        }

        private void DownloadsAndUpdatesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            HeaderRightButtonsDownloadButtonClick(sender, e);
        }
    }
}
