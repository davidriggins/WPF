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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WindowsStoreClone.UserControls;

namespace WindowsStoreClone.Pages
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public delegate void OnAppClicked(AnAppUC sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;

        public delegate void OnTopAppButtonClicked(object sender, RoutedEventArgs e);
        public event OnTopAppButtonClicked TopAppButtonClicked;

        public Main()
        {
            InitializeComponent();

            DealsAppsViewer.AppClicked += AnAppClicked;

            ProductivityTopApps.AppClicked += AnAppClicked;

            ProductivityAppsL1.AppClicked += AnAppClicked;
            ProductivityAppsL2.AppClicked += AnAppClicked;
            ProductivityAppsL3.AppClicked += AnAppClicked;

            TopApps.TopAppButtonClicked += TopApps_TopAppButtonClicked;
            TopApps.AppClicked += AnAppClicked;
            EntertainmentAppsViewer.AppClicked += AnAppClicked;
            GamingAppsViewer.AppClicked += AnAppClicked;
            FeaturesAppViewer.AppClicked += AnAppClicked;
            MostPopularAppViewer.AppClicked += AnAppClicked;
            TopFreeAppViewer.AppClicked += AnAppClicked;
            TopFreeGamesAppViewer.AppClicked += AnAppClicked;

            RightHeaderButtons.HeaderRightButtonsDownloadButtonClick += RightHeaderButtons_HeaderRightButtonsDownloadButtonClick;
        }

        private void AnAppClicked(AnAppUC sender, RoutedEventArgs e)
        {
            AppClicked?.Invoke(sender, e);
        }

        private void RightHeaderButtons_HeaderRightButtonsDownloadButtonClick(object sender, RoutedEventArgs e)
        {
            //TODO: Step 7: This will UC will be implemented in the next chapter
        }

        private void MainScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            UIElement element = sender as UIElement;
            element.Opacity = 0;
            DoubleAnimation animation = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(1));

            element.BeginAnimation(UIElement.OpacityProperty, animation);
        }

        private void TopApps_TopAppButtonClicked(object sender, RoutedEventArgs e)
        {
            TopAppButtonClicked?.Invoke(sender, e);
        }

        private void Page_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            //TODO: Step 5: Signal that mouse has been clicked somewhere outside
            //of the header right buttons user control
            RightHeaderButtons.MouseDown_OutsideOfHeaderRightButtons(IsMouseOver, e);
        }
    }
}
