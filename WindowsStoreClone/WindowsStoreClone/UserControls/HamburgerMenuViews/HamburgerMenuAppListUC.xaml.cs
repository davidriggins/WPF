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
            AppsOnFilter = AllApps.Where(p => p.Type == inFilter).ToList();
            AddToMainStackPanel(AppsOnFilter);
        }

        public void AddAll()
        {
            AppsOnFilter = new List<HamburgerMenuAppUC>();
            AddToMainStackPanel(AllApps);
        }

        public void SortByName()
        {
            List<HamburgerMenuAppUC> AllAppsSorted = new List<HamburgerMenuAppUC>();
            if (AppsOnFilter.Count < 1)
            {
                AllAppsSorted = AllApps.OrderBy(app => app.AppName).ToList();
            }
            else
            {
                AllAppsSorted = AppsOnFilter.OrderBy(app => app.AppName).ToList();
            }

            AddToMainStackPanel(AllAppsSorted);
        }

        public void SortByDate()
        {
            List<HamburgerMenuAppUC> AllAppsSorted = new List<HamburgerMenuAppUC>();
            if (AppsOnFilter.Count < 1)
            {
                AllAppsSorted = AllApps.OrderByDescending(app => app.Purchased).ToList();
            }
            else
            {
                AllAppsSorted = AppsOnFilter.OrderByDescending(app => app.Purchased).ToList();
            }

            AddToMainStackPanel(AllAppsSorted);
        }

        private void AddToMainStackPanel(List<HamburgerMenuAppUC> inList)
        {
            MainStackPanel.Children.Clear();
            foreach (HamburgerMenuAppUC app in inList)
            {
                MainStackPanel.Children.Add(app);
            }
        }
    }
}
