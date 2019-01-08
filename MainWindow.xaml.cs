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

namespace _2018_01_08_Own_Control
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

        double ertek = 0;
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            try
            {
                string leendoSzoveg = txt.Text.Substring(0, txt.SelectionStart) + e.Text + txt.Text.Substring(txt.SelectionStart + txt.SelectionLength);
                ertek = double.Parse(leendoSzoveg);
            }
            catch (Exception)
            {
                e.Handled = true;
            }
        }
    }
}
