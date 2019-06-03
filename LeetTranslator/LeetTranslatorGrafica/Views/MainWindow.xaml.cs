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
        }


        /// <summary>
        /// Start the translation process.
        /// Take the plain text and call the right   ModelView method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void translateBtn_Click(object sender, RoutedEventArgs e)
        {
            string text = new TextRange(translateTxt.Document.ContentStart, translateTxt.Document.ContentEnd).Text;
            translatedTxt.Document.Blocks.Clear();

            translatedTxt.AppendText((DataContext as ViewModels.MainWindowViewModel).Translate(text));
        }

        /// <summary>
        /// Perform when the window is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void window_Loaded(object sender, RoutedEventArgs e)
        {
            clearBtn_Click(null, null);

            //todo: delete this setting
            if (Properties.Settings.Default.DarkTheme)
                SetDarkTheme();
            else
                SetLightTheme();
        }

        /// <summary>
        /// Clean text field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            translateTxt.Document.Blocks.Clear();
            translatedTxt.Document.Blocks.Clear();
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
        private void OpenFile(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Open");
        }

        /// <summary>
        /// Save a new (or already existing) leet file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFile(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save");
        }

        /// <summary>
        /// Open window settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSettings(object sender, RoutedEventArgs e)
        {
            //todo: refactor mvvm
            bool dark_theme = Properties.Settings.Default.DarkTheme;

            //todo: move creation logic to MainVindowViewModel
            new Settings((DataContext as ViewModels.MainWindowViewModel).Settings()).ShowDialog();
            //new Settings(new ViewModels.SettingsViewModel(null)).ShowDialog();

            if (dark_theme != Properties.Settings.Default.DarkTheme)
            {
                if (Properties.Settings.Default.DarkTheme)
                    SetDarkTheme();
                else
                    SetLightTheme();
            }
        }

        /// <summary>
        /// Close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseApp(object sender, RoutedEventArgs e)
        {
            CloseApp();
        }


        /***** ? *****/

        /// <summary>
        /// Show info about this software
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowInfo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Leet Translator Graphics - Alessandro Bianchi", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        /// <summary>
        /// Set the color of the GUI according Dark Theme rules
        /// </summary>
        private void SetDarkTheme()
        {
            SetTheme(Models.Theme.DARK_TEXT, Models.Theme.DARK_BACKGROUND, Models.Theme.DARK_CONTROLS);
        }

        /// <summary>
        /// Set the color of the GUI according Light Theme rules
        /// </summary>
        private void SetLightTheme()
        {
            SetTheme(Models.Theme.LIGHT_TEXT, Models.Theme.LIGHT_BACKGROUND, Models.Theme.LIGHT_CONTROLS);
        }

        /// <summary>
        /// Set the color of the GUI according to the parameter
        /// </summary>
        /// <param name="text">Color of text</param>
        /// <param name="background">Color of window background</param>
        /// <param name="controls">Color of controls background (e.g.,  buttons or text form)</param>
        private void SetTheme(string text, string background, string controls)
        {
            //Use this brush to recolor theme
            Brush brush;

            //Create brush for background
            brush = Models.Theme.CreateBrush(background);

            principalGrid.Background = brush;

            mainMenu.Background = brush;

            //Create brush for controls
            brush = Models.Theme.CreateBrush(controls);

            //Button
            translateBtn.Background = brush;
            clearBtn.Background = brush;
            //settingsBtn.Background = brush;
            //infoBtn.Background = brush;

            //Text form
            translateTxt.Background = brush;
            translatedTxt.Background = brush;

            

            //Create brush for text
            brush = Models.Theme.CreateBrush(text);

            //Button and general controls
            //titleLab.Foreground = brush;
            //light_leetRadio.Foreground = brush;
            //complete_leetRadio.Foreground = brush;
            write_on_fileCheck.Foreground = brush;
            translateBtn.Foreground = brush;
            clearBtn.Foreground = brush;
            //infoBtn.Foreground = brush;
            //settingsBtn.Foreground = brush;

            //Text form
            translateTxt.Foreground = brush;
            translatedTxt.Foreground = brush;

            
            mainMenu.Foreground = brush;
        }

        

        private void CloseApp()
        {
            this.Close();
        }

        
    }
}
