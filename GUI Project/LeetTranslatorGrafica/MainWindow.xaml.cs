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

namespace LeetTranslatorGrafica
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void translateBtn_Click(object sender, RoutedEventArgs e)
        {
            string text = new TextRange(translateTxt.Document.ContentStart, translateTxt.Document.ContentEnd).Text;

            translatedTxt.Document.Blocks.Clear();


            if ((bool)light_leetRadio.IsChecked)
            {
                if (!(bool)write_on_fileCheck.IsChecked)
                    translatedTxt.AppendText(Translator.LightLeet(text));
                else
                {
                    Translator.TranslateOnFile(text, Translator.LightLeet);
                    MessageBox.Show("Translation done", "Translation done", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                if (!(bool)write_on_fileCheck.IsChecked)
                    translatedTxt.AppendText(Translator.CompleteLeet(text));
                else
                {
                    Translator.TranslateOnFile(text, Translator.CompleteLeet);
                    MessageBox.Show("Translation done", "Translation done", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void window_Loaded_1(object sender, RoutedEventArgs e)
        {
            clearBtn_Click(null, null);
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            translateTxt.Document.Blocks.Clear();
            translatedTxt.Document.Blocks.Clear();
        }

        private void infoBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Leet Translator Graphics - Alessandro Bianchi", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
