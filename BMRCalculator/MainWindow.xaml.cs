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

namespace BMRCalculator
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // Man radio check.
            //These code here in man check radio is just a pre-alpha code, just ignore it.

            /*int age = Convert.ToInt32(txtAge.Text);
            int weight = Convert.ToInt32(txtWeight.Text);
            int height = Convert.ToInt32(txtHeight.Text);
            double maleBMR = weight * 10 + height * 6.25 - age * 5 - 5;*/
        }

        private void radioWoman_Checked(object sender, RoutedEventArgs e)
        {
            //Woman radio check.
            ////These code here in woman check radio is just a pre-alpha code, just ignore it.

            /*int age = Convert.ToInt32(txtAge.Text);
            int weight = Convert.ToInt32(txtWeight.Text);
            int height = Convert.ToInt32(txtHeight.Text);
            double femaleBMR = weight * 10 + height * 6.25 - age * 5 - 161;*/
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Convert age, weight, and height into int and double.
            int Age = Convert.ToInt32(txtAge.Text);
            double Weight = Convert.ToDouble(txtWeight.Text);
            double Height = Convert.ToDouble(txtHeight.Text);

            //Declare formular of BMR for men and women.
            double maleBMR = Weight * 10 + Height * 6.25 - Age * 5 - 5;
            double femaleBMR = Weight * 10 + Height * 6.25 - Age * 5 - 161;

            //Declare total BMR of men and women into string.
            string totalMale = maleBMR.ToString();
            string totalFemale = femaleBMR.ToString();

            if (radioMan.IsChecked == true)
            {
                txtTotal.Text = totalMale + " kcal per day.";
            }

            if(radioWoman.IsChecked == true)
            {
                txtTotal.Text = totalFemale + " kcal per day.";
            }

            if(radioMan.IsChecked == false && radioWoman.IsChecked == false)
            {
                MessageBox.Show("Please, select your gender first before calculate!");
            }
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            txtAge.Clear();
            txtHeight.Clear();
            txtWeight.Clear();
            txtTotal.Text = "";
        }
    }
}
