/* Austin McKee
*March 29, 2019
*This Program takes the user's input of certain shortforms or slang that teens text with and outputs the correct slang translation. If TTYL is entered, the program ends.
*/
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

namespace _184905MessageTranslator
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

        private void TranslateButton_Click(object sender, RoutedEventArgs e)
        {
            string TextInput = TextBoxShortForm.Text;
            int End = 0;
            while (End == 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine("value of i: (0)", i);
                }
                TextInput = TextBoxShortForm.Text.ToUpper();

                TextInput = TextInput.Replace(":-)", "I'm Happy" + Environment.NewLine);
                TextInput = TextInput.Replace(":-(", "I'm Sad" + Environment.NewLine);
                TextInput = TextInput.Replace(";-)", "Wink" + Environment.NewLine);
                TextInput = TextInput.Replace(":-P", "Stick Out My Tounge" + Environment.NewLine);
                TextInput = TextInput.Replace("~.~", "I'm Sleepy" + Environment.NewLine);
                TextInput = TextInput.Replace("TA", "Totally Awesome" + Environment.NewLine);
                TextInput = TextInput.Replace("CCC", "Canadian Computing Competition" + Environment.NewLine);
                TextInput = TextInput.Replace("CUZ", "Because" + Environment.NewLine);
                TextInput = TextInput.Replace("TTYL", "Talk To You Later" +Environment.NewLine);
                TextInput = TextInput.Replace("TY", "Thank You" + Environment.NewLine);
                TextInput = TextInput.Replace("YW", "Your Welcome" + Environment.NewLine);
                TextInput = TextInput.Replace("CU", "See You" + Environment.NewLine);
            }
               OutputLabel.Content = " " + TextInput;
            if (TextBoxShortForm.Text.ToUpper().Contains("TTYL"))
            {
                Environment.Exit(0);
            }                                                 
           
        }
    }
}
