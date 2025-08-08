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

namespace CatYearsCodeBehindDemo;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public TextBlock ResultTextBlock;
    public TextBox InputCatAge;

    public MainWindow()
    {
        InitializeComponent();

        Image backgroundImage = new Image()
        {
            Source = new BitmapImage(new Uri(Environment.CurrentDirectory + @"\..\..\..\Images\Cat.jpg", UriKind.RelativeOrAbsolute))
        };

        ResultTextBlock = new TextBlock()
        {
            Text = "Your cat is ",
            FontSize = 18,
        };

        InputCatAge = new TextBox()
        {
            Width = 120,
            TextAlignment = TextAlignment.Center,
            FontSize = 16,
            Margin = new Thickness(5, 0, 0, 0)
        };

        InputCatAge.KeyDown += InputCatAge_KeyDown;

        TextBlock userQuestion = new TextBlock()
        {
            Text = "How old is your cat?",
            FontSize = 18,
        };

        StackPanel HorizontalSp = new StackPanel()
        {
            Orientation = Orientation.Horizontal,
            Margin = new Thickness(1, 5, 0, 0),
        };

        HorizontalSp.Children.Add(userQuestion);
        HorizontalSp.Children.Add(InputCatAge);

        StackPanel MainVerticalStackPanel = new StackPanel()
        {
            Orientation = Orientation.Vertical,
        };

        MainVerticalStackPanel.Children.Add(HorizontalSp);
        MainVerticalStackPanel.Children.Add(ResultTextBlock);
        MainVerticalStackPanel.Children.Add(backgroundImage);


        myMainWindow.Content = MainVerticalStackPanel;
    }

    private void InputCatAge_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            try
            {
                int inputCatAge = Int32.Parse(InputCatAge.Text);
                string resultHumanAge = "";

                if (inputCatAge > 0 && inputCatAge < 1)
                {
                    resultHumanAge = "0-15";
                    ResultTextBlock.Text = $"Your cat's age in human years is: {resultHumanAge}";
                }
                else if (inputCatAge >= 2 && inputCatAge < 25)
                {
                    resultHumanAge = (((inputCatAge - 2) * 4) + 24).ToString();
                    ResultTextBlock.Text = $"Your cat's age in human years is: {resultHumanAge}";
                }
                else
                {
                    ResultTextBlock.Text = "You entered a value that is not between 0-25. " +
                                             "Your cat must be super old or not yet born!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Invalid input: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}