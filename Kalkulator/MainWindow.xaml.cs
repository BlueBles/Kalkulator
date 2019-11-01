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

namespace Kalkulator
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    /// 

    
    public partial class MainWindow : Window
    {
        string wynikString;
        float  total1Float = 0;
        float total2Float = 0;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool multiplyButtonClicked = false;
        bool divideButtonClicked = false;

        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void PoleTekstowe_TextChanged(object sender, TextChangedEventArgs e)
        {
            wynikString = this.PoleTekstowe.Text;
        }
        private void Button0_Click(object sender, RoutedEventArgs e) // zabezpieczone (przed wstawianiem zer na początek), dodaje 0 do string
        {
            if (PoleTekstowe.Text.Length == 0)
            {
                this.PoleTekstowe.Text += "";
            }
            else
            {
                this.PoleTekstowe.Text += "0";
            }
            
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.PoleTekstowe.Text += "1";
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            this.PoleTekstowe.Text += "2";
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            this.PoleTekstowe.Text += "3";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            this.PoleTekstowe.Text += "4";
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            this.PoleTekstowe.Text += "5";
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            this.PoleTekstowe.Text += "6";
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            this.PoleTekstowe.Text += "7";
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            this.PoleTekstowe.Text += "8";
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            this.PoleTekstowe.Text += "9";
        }

        private void ButtonX_Click(object sender, RoutedEventArgs e)//zrobic
        {
            total1Float += float.Parse(PoleTekstowe.Text);
            PoleTekstowe.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = true;
            divideButtonClicked = false;
        }

        private void Buttonminus_Click(object sender, RoutedEventArgs e)//zrobic
        {
            total1Float += float.Parse(PoleTekstowe.Text);
            PoleTekstowe.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = true;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
        }

        private void Buttonplus_Click(object sender, RoutedEventArgs e)//zrobic 
        {
            total1Float += float.Parse(PoleTekstowe.Text);
            PoleTekstowe.Text = "";

            plusButtonClicked = true;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
        }

        private void Buttonequal_Click(object sender, RoutedEventArgs e) //zrobic
        {
            if (plusButtonClicked == true)
            {
                total2Float = total1Float + float.Parse(PoleTekstowe.Text);
                PoleTekstowe.Text = total2Float.ToString();
                total1Float = 0;
            }
            else if (minusButtonClicked == true)
            {
                total2Float = total1Float - float.Parse(PoleTekstowe.Text);
                PoleTekstowe.Text = total2Float.ToString();
                total1Float = 0;
            }
            else if (multiplyButtonClicked == true)
            {
                total2Float = total1Float * float.Parse(PoleTekstowe.Text);
                PoleTekstowe.Text = total2Float.ToString();
                total1Float = 0;
            }
            else if (divideButtonClicked == true)
            {
                total2Float = total1Float / float.Parse(PoleTekstowe.Text);
                PoleTekstowe.Text = total2Float.ToString();
                total1Float = 0;
            }

        }

        private void Buttoncolon_Click(object sender, RoutedEventArgs e)  // gdy jest pierwszy a string jest pusty wpisuje "0,"
        {
            
            if(PoleTekstowe.Text.Length == 0)
            {
                this.PoleTekstowe.Text += "0,";
            }
            else
            {
                this.PoleTekstowe.Text += ",";
            }
            
        }

        private void Buttonplusminus_Click(object sender, RoutedEventArgs e) //zrobic
        {
            this.PoleTekstowe.Text.Insert(0, "-");
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            PoleTekstowe.Text = "";
            total1Float = 0;
            total2Float = 0;
        }

        private void Buttonsqrt_Click(object sender, RoutedEventArgs e) //zrobic
        {
            this.PoleTekstowe.Text += "sqrt";
        }

        private void Buttondivide_Click(object sender, RoutedEventArgs e)
        {
            total1Float += float.Parse(PoleTekstowe.Text);
            PoleTekstowe.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = true;
        }
    }
}
