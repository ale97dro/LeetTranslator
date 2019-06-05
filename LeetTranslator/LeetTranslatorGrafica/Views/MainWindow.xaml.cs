using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace LeetTranslatorGrafica.Views
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(ViewModels.MainWindowViewModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;

            //Properties.Settings.Default.Reset();
        }


        /// <summary>
        /// Start the translation process.
        /// Take the plain text and call the right   ModelView method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TranslateClick(object sender, RoutedEventArgs e)
        {
            string text = GetPlainText();
            ClearPlainTextArea();

            translatedTxt.AppendText((DataContext as ViewModels.MainWindowViewModel).Translate(text));
        }

        
        /// <summary>
        /// Perform when the window is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            ClearTextAreas();

            if(Properties.Settings.Default.Theme != "")
                SetTheme(Models.Theme.Deserialize(Properties.Settings.Default.Theme));
        }

        

        /// <summary>
        /// Clean text field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearTextAreasClick(object sender, RoutedEventArgs e)
        {
            ClearTextAreas();
        }

        
        /********************************
         *                              *
         *                              *
         *         MENU HANDLER         *
         *                              *
         *                              *
         ********************************/


        /***** FILE *****/
        /// <summary>
        /// Open an existing leet file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Open");
        }

        /// <summary>
        /// Save a new (or already existing) leet file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFileClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save");
        }


        /** IMPORT **/
        private void ImportPlainTextClick(object sender, RoutedEventArgs e)
        {
            ClearTextAreas();
            translateTxt.AppendText((DataContext as ViewModels.MainWindowViewModel).ImportTextFile());
        }

        /** EXPORT **/
        private void ExportPlainTextClick(object sender, RoutedEventArgs e)
        {
            (DataContext as ViewModels.MainWindowViewModel).ExportTextFile(GetPlainText());
        }

        private void ExportLeetTextClick(object sender, RoutedEventArgs e)
        {
            (DataContext as ViewModels.MainWindowViewModel).ExportTextFile(GetLeetText());
        }


        /// <summary>
        /// Open window settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSettingsClick(object sender, RoutedEventArgs e)
        {
            new Settings((DataContext as ViewModels.MainWindowViewModel).Settings()).ShowDialog();

            SetTheme(Models.Theme.Deserialize(Properties.Settings.Default.Theme));
        }

        /// <summary>
        /// Close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseApplicationClick(object sender, RoutedEventArgs e)
        {
            CloseApp();
        }


        /***** ? *****/

        /// <summary>
        /// Show info about this software
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowInfoClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Leet Translator Graphics - Alessandro Bianchi", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Help for the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Help");
        }


        private void SetTheme(Models.Theme t)
        {
            //Use this brush to recolor theme
            Brush brush;

            //Create brush for background
            brush = Models.Theme.CreateBrush(t.BackgroundColor);

            principalGrid.Background = brush;

            mainMenu.Background = brush;

            //Create brush for controls
            brush = Models.Theme.CreateBrush(t.ControlsColor);

            //Button
            translateBtn.Background = brush;
            clearBtn.Background = brush;
            //settingsBtn.Background = brush;
            //infoBtn.Background = brush;

            //Text form
            translateTxt.Background = brush;
            translatedTxt.Background = brush;



            //Create brush for text
            brush = Models.Theme.CreateBrush(t.TextColor);

            //Button and general controls
            //titleLab.Foreground = brush;
            //light_leetRadio.Foreground = brush;
            //complete_leetRadio.Foreground = brush;
            //write_on_fileCheck.Foreground = brush;
            translateBtn.Foreground = brush;
            clearBtn.Foreground = brush;
            //infoBtn.Foreground = brush;
            //settingsBtn.Foreground = brush;

            //Text form
            translateTxt.Foreground = brush;
            translatedTxt.Foreground = brush;


            mainMenu.Foreground = brush;
        }


        /// <summary>
        /// Get the plain text from the RichTextBox
        /// </summary>
        /// <returns>Plain text</returns>
        private string GetPlainText()
        {
            try
            {
                return new TextRange(translateTxt.Document.ContentStart, translateTxt.Document.ContentEnd).Text;
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// Get the leet text from the RichTextBox
        /// </summary>
        /// <returns>Leet text</returns>
        private string GetLeetText()
        {
            try
            {
                return new TextRange(translatedTxt.Document.ContentStart, translateTxt.Document.ContentEnd).Text;
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// Clear the plain text RichTextBox
        /// </summary>
        private void ClearPlainTextArea()
        {
            translateTxt.Document.Blocks.Clear();
        }

        /// <summary>
        /// Clear the leet text RichTextBox
        /// </summary>
        private void ClearLeetTextArea()
        {
            translatedTxt.Document.Blocks.Clear();
        }

        /// <summary>
        /// Clear all the text areas
        /// </summary>
        private void ClearTextAreas()
        {
            ClearPlainTextArea();
            ClearLeetTextArea();
        }

        /// <summary>
        /// Close the application
        /// </summary>
        private void CloseApp()
        {
            this.Close();
        }

        
    }
}
