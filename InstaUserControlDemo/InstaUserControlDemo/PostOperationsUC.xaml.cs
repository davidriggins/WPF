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

namespace InstaUserControlDemo
{
    /// <summary>
    /// Interaction logic for PostOperationsUC.xaml
    /// </summary>
    public partial class PostOperationsUC : UserControl
    {
        public bool PostLiked { get; set; }

        public PostOperationsUC()
        {
            InitializeComponent();
        }

        public void LikePost()
        {
            Heart.Source = new BitmapImage(
                new Uri("pack://application:,,,/Icons/like.png", UriKind.Absolute));

            PostLiked = true;
        }

        public void UnikePost()
        {
            Heart.Source = new BitmapImage(
                new Uri("pack://application:,,,/Icons/nolike.png", UriKind.Absolute));

            PostLiked = false;
        }

        private void Heart_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!PostLiked)
            {
                LikePost();
            }
            else
            {
                UnikePost();
            }
        }
    }
}
