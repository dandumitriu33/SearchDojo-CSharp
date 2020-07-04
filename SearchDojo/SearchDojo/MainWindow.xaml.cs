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
using System.Text.RegularExpressions;

namespace SearchDojo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var source = UserText.Text;
            var pattern = UserPattern.Text;
            StringBuilder sb = new StringBuilder();
            Regex rgx = new Regex(pattern);
            foreach (Match match in rgx.Matches(source))
            {
                sb.Append($"{match.Value}\n");
                Console.WriteLine($"{match.Value}\n");
            }
            MatchedResult.Text = sb.ToString(); 
        }
    }
}
