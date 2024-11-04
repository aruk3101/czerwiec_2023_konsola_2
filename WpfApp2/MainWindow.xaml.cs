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

namespace WpfApp2
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

        private void OnSprawdzCeneClick(object sender, RoutedEventArgs e)
        {
            if (radioPocztowka.IsChecked == true)
            {
                imgPrzesylka.Source = new BitmapImage(new Uri("/pocztowka.png", UriKind.Relative));
                lblCena.Content = "Cena: 1 zł";
            }
            else if (radioList.IsChecked == true)
            {
                imgPrzesylka.Source = new BitmapImage(new Uri("/list.png", UriKind.Relative));
                lblCena.Content = "Cena: 1,5 zł";
            }
            else if (radioPaczka.IsChecked == true)
            {
                imgPrzesylka.Source = new BitmapImage(new Uri("/paczka.png", UriKind.Relative));
                lblCena.Content = "Cena: 10 zł";
            }
        }
    }
}