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

namespace WindowsStoreClone.UserControls.AppDetailsTabContent
{
    /// <summary>
    /// Interaction logic for AReviewUC.xaml
    /// </summary>
    public partial class AReviewUC : UserControl
    {
        List<string> Names;

        public AReviewUC()
        {
            InitializeComponent();
            Names = new List<string>()
            {
                "Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Hannah", "Ivy", "Jack",
                "Kathy", "Leo", "Mona", "Nina", "Oscar", "Paul", "Quinn", "Rachel", "Sam", "Tina"
            };

            string reviewerName = Names[new Random().Next(Names.Count)];
            ReviewerNameLabel.Content = reviewerName;
            AvatarLabel.Content = reviewerName[0];
            NumOfStarsLabel.Content = GetRandomNumOfStars();
        }

        private string GetRandomNumOfStars()
        {
            Random rand = new Random();
            int numOfStars = rand.Next(1, 6); // Random number between 1 and 5
            return new string('★', numOfStars) + new string('☆', 5 - numOfStars);
        }

        private string GetReviewTitleBasedOnStars(string inStars)
        {
            if (inStars == null) { return "No Rating"; }
            int starCount = inStars.Count(c => c == '★');
            return starCount switch
            {
                5 => "Excellent",
                4 => "Very Good",
                3 => "Good",
                2 => "Fair",
                1 => "Poor",
                _ => "No Rating",
            };
        }
    }
}
