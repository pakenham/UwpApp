using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UwpApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // creating variables
        string op; 
        double op1, op2, result ,r, opp ;

        public MainPage()
        {
            this.InitializeComponent();
        } // constructor

        private void num1_Click(object sender, RoutedEventArgs e)
        {
                textbox1.Text += "1";
        }

        private void num2_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "2";
        }

        private void num3_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "3";
        }

        private void num4_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "4";
        }

        private void num5_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "5";
        }

        private void num6_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "6";
        }

        private void num7_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "7";
        }

        private void num8_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "8";
        }

        private void num9_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "9";
        }

        private void num0_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "0";
        }

        /*private async void Button_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("I want to go home.");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }*/

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = string.Empty;
        }

        private void plusbutton_Click(object sender, RoutedEventArgs e)
        {
            op1 = Convert.ToDouble(textbox1.Text);
            op = "+";
            textbox1.Text = " ";
            /*if ()
            {
                myEqualMethod();
            }*/
     
        }

        private void equalbutton_Click(object sender, RoutedEventArgs e)
        {
            myEqualMethod();
        }

        private void myEqualMethod()
        {
            if(opp == 2)
            {
                textbox1.Text = Convert.ToString(r);
                opp = 0;
            }
            op2 = Convert.ToDouble(textbox1.Text);  // convert string to double for calculating 
              

             switch (op)
                {
                    case "+":
                        result = op1 + op2;
                        textbox1.Text = Convert.ToString(result); // convert double to string for display
                        break;
                    case "-":
                        result = op1 - op2;
                        textbox1.Text = Convert.ToString(result);
                        break;
                    case "*":
                        result = op1 * op2;
                        textbox1.Text = Convert.ToString(result); // convert double to string for display
                        break;
                    case "/":
                        if (op2 == 0)
                        {
                            textbox1.Text = "ERROR";
                            break;
                        }
                        else
                        {
                            result = op1 / op2;
                            textbox1.Text = Convert.ToString(result);
                            break;
                        }
                    /*case "%":
                        result = op2 * (op1 / 100);
                        textbox1.Text = Convert.ToString(result);
                        break;*/

            }
                      
        }

        private void minusbutton_Click(object sender, RoutedEventArgs e)
        {
            op1 = Convert.ToDouble(textbox1.Text);
            op = "-";
            textbox1.Text = " ";
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            op1 = Convert.ToDouble(textbox1.Text);
            op = "*";
            textbox1.Text = " ";
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            op1 = Convert.ToDouble(textbox1.Text);
            op = "/";
            textbox1.Text = " ";
        }

        private void dot_Click(object sender, RoutedEventArgs e)
        {
            if(textbox1.Text == ".") // check if dot is already present/not
            {
                textbox1.Text = textbox1.Text;
            }
            else
            {
                textbox1.Text += ".";
            }         
        }

        private void percent_Click(object sender, RoutedEventArgs e)
        {
            op2 = Convert.ToDouble(textbox1.Text);
            opp = 2;
            r = op1 * (op2 / 100);

            
            textbox1.Text = " ";

        }


    }
}
