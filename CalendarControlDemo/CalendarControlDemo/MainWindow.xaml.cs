using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalendarControlDemo;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        myTextBlock.Text = myCalendar.SelectedDate?.ToString("D") ?? "No date selected";
    }

    private void myCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
    {
        myTextBlock.Text = myCalendar.SelectedDate?.ToString("D") ?? "No date selected";
    }
}