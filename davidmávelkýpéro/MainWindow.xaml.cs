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

namespace davidmávelkýpéro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string znaky = "aábcčdďeéěfghiíjklmnňoópqrřsštťuúůvwxyýzž,.; ";
        string znakyObracene = "žzýyxwvůúuťtšsřrqpóoňnmlkjíihgfěéeďdčcbáa,.; ";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Encode_Click(object sender, RoutedEventArgs e)
        {
            EncodeOutro.Text = EncoderMetoda();
        }
        private string EncoderMetoda()
        {
            string obsahTxt = EncodeEntry.Text.ToLower();
            string prevracenyTxt = "";
            for (int i = 0; i < obsahTxt.Length; i++)
            {
                char znak = obsahTxt[i];
                int index = znaky.IndexOf(znak);
                prevracenyTxt += znakyObracene[index];
            }
            return prevracenyTxt;
        }
    }
}
