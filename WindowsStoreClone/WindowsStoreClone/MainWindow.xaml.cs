﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WindowsStoreClone.Pages;

namespace WindowsStoreClone;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private Main MainWindowContentPage;

    public MainWindow()
    {
        InitializeComponent();

        MainWindowContentPage = new Main();
    }

    private void MainWindowFrame_Loaded(object sender, RoutedEventArgs e)
    {
        AppDetails myAppDetails = new AppDetails();
        MainWindowFrame.Content = myAppDetails;
    }
}