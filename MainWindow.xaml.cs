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

namespace Homework4_Part1
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
            double Weight = Convert.ToDouble(weight.Text);
            double Height = Convert.ToDouble(height.Text);

            double BMI = Weight * 720 / (Height*Height);
            BMI = Math.Round(BMI, 2);

            label.Content = "Your BMI: "+BMI;

            if (BMI > 26)
            {
                canvas.Background = Brushes.Yellow;
            }
            else if (BMI > 15)
            {
                canvas.Background = Brushes.Green;
            }
            else {
                canvas.Background = Brushes.Blue;
            }
        }
    }
}