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

namespace calc
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

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double co, ca, hi, ang1, ang2, conv;

                ca = Convert.ToDouble(cateto1.Text);
                co = Convert.ToDouble(cateto2.Text);

                if (co > 0 && ca > 0)
                {
                    hi = Math.Sqrt(Math.Pow(co, 2) + Math.Pow(ca, 2));

                    conv = 180 / Math.PI;

                    ang1 = conv * Math.Asin(co / hi);
                    ang2 = conv * Math.Asin(ca / hi);

                    r.Text = "Hipotenusa: " + hi.ToString("0.00000") + "\nÂngulo α: " + ang1.ToString("0.00000") + "\nÂngulo β: " + ang2.ToString("0.00000");
                }
                else
                {
                    r.Text = "-Não pode ter valores menores ou igual a zero!";
                }
            }
            catch{
                r.Text = "-Não pode ter letras ou caracteres especiais!\n-E nem espaços em branco!";
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                double co, ca, hi, ang1, ang2;

                ca = Convert.ToDouble(cateto1.Text);
                co = Convert.ToDouble(cateto2.Text);
                if (co > 0 && ca > 0)
                {
                    hi = Math.Sqrt(Math.Pow(co, 2) + Math.Pow(ca, 2));

                    ang1 = Math.Asin(co / hi);
                    ang2 = Math.Asin(ca / hi);

                    r.Text = "Hipotenusa: " + hi.ToString("0.00000") + "\nÂngulo α: " + ang1.ToString("0.00000") + "\nÂngulo β: " + ang2.ToString("0.00000");
                }
                else
                {
                    r.Text = "-Não pode ter valores menores ou igual a zero!";
                }
            }
            catch
            {
                r.Text = "-Não pode ter letras ou caracteres especiais!\n-E nem espaços em branco!";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            cateto1.Text = "";
            cateto2.Text = "";
            r.Text = "";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}