using InstaUserControlDemo.Models;
using InstaUserControlDemo.UserControls;
using System.Windows;

namespace InstaUserControlDemo;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        MainStackPanel.Children.Add(new VideoPostUC(new VideoPostModel()));

        MainStackPanel.Children.Add(new PicturePostUC());
    }
}