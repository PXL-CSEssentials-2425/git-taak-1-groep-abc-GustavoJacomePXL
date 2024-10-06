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

namespace GIT_taak_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string redCode = "#FF0000";
        string greenCode = "#008000";
        string yellowCode = "#FFFF00";
        string blueCode = "#0000FF";

        public MainWindow()
        {
            InitializeComponent();
        }

        // Toon de kleurencode als er op een kleur geklikt wordt
        private void redImage_Click(object sender, RoutedEventArgs e)
        {
            codeTextbox.Text = redCode;
        }

        private void greenImage_Click(object sender, RoutedEventArgs e)
        {
            codeTextbox.Text = greenCode;
        }

        private void yellowImage_Click(object sender, RoutedEventArgs e)
        {
            codeTextbox.Text = yellowCode;
        }

        private void blueImage_Click(object sender, RoutedEventArgs e)
        {
            codeTextbox.Text = blueCode;
        }

        // Verrander de achtergrondkleur naar de corresponderende kleur als de gebruiker er over zweeft met de muis
        private void redImage_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Red;
        }

        private void greenImage_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Green;
        }

        private void yellowImage_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Yellow;
        }

        private void blueImage_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Blue;
        }

        // Verander de kleur terug naar lichtgrijs als de gebruiker van de image af gaat met de muis
        private void redImage_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void greenImage_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void yellowImage_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void blueImage_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }
    }
}