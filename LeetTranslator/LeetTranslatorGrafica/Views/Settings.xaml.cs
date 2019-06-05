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
        public Settings(ViewModels.SettingsViewModel vm)
        {
            InitializeComponent();

            DataContext = vm;
        }

        /// <summary>
        /// Save changes to settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkClick(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Save();

            CloseWindow();
        }

        /// <summary>
        /// Discard new settings and close window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelClick(object sender, RoutedEventArgs e)
        {
            CloseWindow();
        }

        /// <summary>
        /// Initialize window with right settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            SetTheme((DataContext as ViewModels.SettingsViewModel).SelectedTheme);
        }

        private void SetTheme(Models.Theme t)
        {
            //Use this brush to recolor theme
            Brush brush;

            //Create brush for background
            brush = Models.Theme.CreateBrush(t.BackgroundColor);

            principalGrid.Background = brush;

            //Create brush for controls background
            brush = Models.Theme.CreateBrush(t.ControlsColor);

            okBtn.Background = brush;
            cancelBtn.Background = brush;
            checkUpdateBtn.Background = brush;

            //Create brush for text
            brush = Models.Theme.CreateBrush(t.TextColor);

            titleLab.Foreground = brush;

            themeLab.Foreground = brush;
            //lightThemeRadio.Foreground = brush;
            //darkThemeRadio.Foreground = brush;

            okBtn.Foreground = brush;
            cancelBtn.Foreground = brush;
            checkUpdateBtn.Foreground = brush;
        }

        private void CloseWindow()
        {
            this.Close();
        }
    }
}
