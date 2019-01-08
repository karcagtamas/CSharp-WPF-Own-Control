using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace _2018_01_08_Own_Control
{
    public class MyNumbericTextBox : TextBox
    {
        double ertek = 0;
        public MyNumbericTextBox()
        {
            PreviewTextInput += MyNumbericTextBox_PreviewTextInput;
        }

        private void MyNumbericTextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            try
            {
                string leendoSzoveg = this.Text.Substring(0, this.SelectionStart) + e.Text + this.Text.Substring(this.SelectionStart + this.SelectionLength);
                this.ertek = double.Parse(leendoSzoveg);
            }
            catch (Exception)
            {
                e.Handled = true;
            }
        }

        public double asDouble
        {
            get
            {
                return ertek;
            }
            set
            {
                ertek = value;
                this.Text = value.ToString();
            }
        }
    }
}
