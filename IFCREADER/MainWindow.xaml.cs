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

namespace IFCREADER
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
            //MessageBox.Show("le gmp n'existe plus");
            Txtbox.AppendText("Le gmp n'existe plus" + "\n");
            Txtbox.AppendText("issou");
            //ahahahah
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

    }
}