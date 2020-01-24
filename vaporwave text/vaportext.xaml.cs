using System;
using System.Collections.Generic;
using System.Linq;
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

namespace vaporwave_text
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = textbox1.Text;
            string vaporedtext = Vaportext(1, text);
            textbox2.Text = vaporedtext;
            Clipboard.SetText(vaporedtext);

        }

        private string Vaportext(int v, string text)
        {
            string temp = "";
          for(int i=0; i < text.Length; i++)
            {
                temp += text[i] + " ";
            }

            return temp;

        }
    }
}
