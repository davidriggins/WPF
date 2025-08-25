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
    /// Interaction logic for AppsViewerUC.xaml
    /// </summary>
    public partial class AppsViewerUC : UserControl
    {
        List<AnAppUC> PresentedApps;

        public AppsViewerUC()
        {
            InitializeComponent();

            PresentedApps = new List<AnAppUC>();
            AppsList.ItemsSource = PresentedApps;

            for (int i = 0; i < 9; i++)
            {
                AnAppUC curr = new AnAppUC();
                PresentedApps.Add(curr);
            }
        }

        private void ScrollLeftButton_Click(object sender, RoutedEventArgs e)
        {
            int widthOfAnApp = (int)PresentedApps.First().ActualWidth + 
                2 * (int)PresentedApps.First().Margin.Left;

            AppsScrollView.ScrollToHorizontalOffset(AppsScrollView.HorizontalOffset - 4 * widthOfAnApp);
        }

        private void ScrollRightButton_Click(object sender, RoutedEventArgs e)
        {
            int widthOfAnApp = (int)PresentedApps.First().ActualWidth +
                2 * (int)PresentedApps.First().Margin.Left;

            AppsScrollView.ScrollToHorizontalOffset(AppsScrollView.HorizontalOffset + 4 * widthOfAnApp);
        }
    }
}
