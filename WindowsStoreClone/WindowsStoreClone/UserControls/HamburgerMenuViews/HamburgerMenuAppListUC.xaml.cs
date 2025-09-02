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
    /// Interaction logic for HamburgerMenuAppListUC.xaml
    /// </summary>
    public partial class HamburgerMenuAppListUC : UserControl
    {
        public List<HamburgerMenuAppUC> AllApps;
        public List<HamburgerMenuAppUC> AppsOnFilter;

        public HamburgerMenuAppListUC()
        {
            InitializeComponent();

            AllApps = new List<HamburgerMenuAppUC>();
            AppsOnFilter = new List<HamburgerMenuAppUC>();

            for (int i = 0; i < 15; i++)
            {
                AddNewHamApp();
            }
        }

        private void AddNewHamApp()
        {
            HamburgerMenuAppUC anApp = new HamburgerMenuAppUC();
            MainStackPanel.Children.Add(anApp);
            AllApps.Add(anApp);
        }

        public void FilterByType(string inFilter)
        {
            AppsOnFilter.Clear();
            AppsOnFilter = AllApps.Where(app => app.Type == inFilter).ToList();
            MainStackPanel.Children.Clear();
            foreach (HamburgerMenuAppUC app in AppsOnFilter)
            {
                MainStackPanel.Children.Add(app);
            }
        }

        public void AddAll()
        {
            MainStackPanel.Children.Clear();
            foreach (HamburgerMenuAppUC app in AllApps)
            {
                MainStackPanel.Children.Add(app);
            }
        }

        public void SortByName()
        {
            List<HamburgerMenuAppUC> AllAppsSorted = AllApps.OrderBy(app => app.AppName).ToList();
            MainStackPanel.Children.Clear();
            foreach (HamburgerMenuAppUC app in AllAppsSorted)
            {
                MainStackPanel.Children.Add(app);
            }
        }

        public void SortByDate()
        {
            List<HamburgerMenuAppUC> AllAppsSorted = AllApps.OrderByDescending(app => app.Purchased).ToList();
            MainStackPanel.Children.Clear();
            foreach (HamburgerMenuAppUC app in AllAppsSorted)
            {
                MainStackPanel.Children.Add(app);
            }
        }
    }
}
