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
using System.Windows.Shapes;

namespace LeetTranslatorGrafica.Views
{
    /// <summary>
    /// Logica di interazione per Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Save changes to settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.DarkTheme = (bool)darkThemeRadio.IsChecked;
            Properties.Settings.Default.Save();

            this.Close();
        }

        /// <summary>
        /// Discard new settings and close window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Initialize window with right settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void window_Loaded(object sender, RoutedEventArgs e)
        {
            lightThemeRadio.IsChecked = !Properties.Settings.Default.DarkTheme;
            darkThemeRadio.IsChecked = Properties.Settings.Default.DarkTheme;

            if (Properties.Settings.Default.DarkTheme)
                SetDarkTheme();
            else
                SetLightTheme();
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

            //Create brush for controls background
            brush = Theme.CreateBrush(controls);

            okBtn.Background = brush;
            cancelBtn.Background = brush;
            checkUpdateBtn.Background = brush;

            //Create brush for text
            brush = Theme.CreateBrush(text);

            titleLab.Foreground = brush;

            themeLab.Foreground = brush;
            lightThemeRadio.Foreground = brush;
            darkThemeRadio.Foreground = brush;

            okBtn.Foreground = brush;
            cancelBtn.Foreground = brush;
            checkUpdateBtn.Foreground = brush;
        }
    }
}
