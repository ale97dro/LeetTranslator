using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LeetTranslatorGrafica.Command
{
    public class MainWindowCommand
    {
        /// <summary>
        /// Create a command to open a leet file.
        /// Shortcut: CTRL+O
        /// </summary>
        public static RoutedCommand OpenCommand
        {
            get
            {
                RoutedCommand cmd = new RoutedCommand();
                cmd.InputGestures.Add(new KeyGesture(Key.O, ModifierKeys.Control));

                return cmd;
            }
        }

        /// <summary>
        /// Create a command to save a leet file.
        /// Shortcut: CTRL+S
        /// </summary>
        public static RoutedCommand SaveCommand
        {
            get
            {
                RoutedCommand cmd = new RoutedCommand();
                cmd.InputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control));

                return cmd;
            }
        }

        /// <summary>
        /// Create a command to open the settings window.
        /// Shortcut: CTRL+I
        /// </summary>
        public static RoutedCommand SettingsCommand
        {
            get
            {
                RoutedCommand cmd = new RoutedCommand();
                cmd.InputGestures.Add(new KeyGesture(Key.I, ModifierKeys.Control));

                return cmd;
            }
        }
    }
}
