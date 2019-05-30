﻿using System;
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
        /// Start the translation process
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

            if (Properties.Settings.Default.DarkTheme)
                SetDarkTheme();
            else
                SetLightTheme();

            //List<string> alpha = new List<string>();

            //alpha.Add("Light");
            //alpha.Add("Complete");
            //alphabetCombo.ItemsSource = alpha;
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

        /// <summary>
        /// Show info about this software
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoBtn_Click(object sender, RoutedEventArgs e)
        {
            //todo: new control
            MessageBox.Show("Leet Translator Graphics - Alessandro Bianchi", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Open new settings window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsBtn_Click(object sender, RoutedEventArgs e)
        {
            //todo: new control
            bool dark_theme = Properties.Settings.Default.DarkTheme;

            new Settings().ShowDialog();

            if(dark_theme!=Properties.Settings.Default.DarkTheme)
            {
                if (Properties.Settings.Default.DarkTheme)
                    SetDarkTheme();
                else
                    SetLightTheme();
            }
        }

        /// <summary>
        /// Set the color of the GUI according Dark Theme rules
        /// </summary>
        private void SetDarkTheme()
        {
            SetTheme(Theme.DARK_TEXT, Theme.DARK_BACKGROUND, Theme.DARK_CONTROLS);
        }

        /// <summary>
        /// Set the color of the GUI according Light Theme rules
        /// </summary>
        private void SetLightTheme()
        {
            SetTheme(Theme.LIGHT_TEXT, Theme.LIGHT_BACKGROUND, Theme.LIGHT_CONTROLS);
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
            brush = Theme.CreateBrush(background);

            principalGrid.Background = brush;

            mainMenu.Background = brush;

            //Create brush for controls
            brush = Theme.CreateBrush(controls);

            //Button
            translateBtn.Background = brush;
            clearBtn.Background = brush;
            //settingsBtn.Background = brush;
            //infoBtn.Background = brush;

            //Text form
            translateTxt.Background = brush;
            translatedTxt.Background = brush;

            

            //Create brush for text
            brush = Theme.CreateBrush(text);

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
    }
}
