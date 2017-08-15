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
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void num7_Click(object sender, RoutedEventArgs e)
        {
            //textbox1.Text += 7.ToString();
            textbox1.Text += num7.Content;

        }

        private void num8_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += num8.Content;
        }

        private void num9_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += num9.Content;
        }

        private void num4_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += num4.Content;
        }

        private void num5_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += num5.Content;
        }

        private void num6_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += num6.Content;
        }

        private void num1_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += num1.Content;
        }

        private void num2_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += num2.Content;
        }

        private void num3_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += num3.Content;
        }

        private void num0_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += num0.Content;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Teacher, I want to go home.");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }
    }
}
