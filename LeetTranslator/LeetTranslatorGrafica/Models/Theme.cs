using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTranslatorGrafica.Models
{
    /// <summary>
    /// Contains information about themes and colors.
    /// Provide tools to manage colors and brushes.
    /// </summary>
    public class Theme
    {
        public const string LIGHT_TEXT = "#FF000000";
        public const string LIGHT_BACKGROUND = "#FFE4E3E3";
        public const string LIGHT_CONTROLS = "#FFFFFFFF";

        public const string DARK_TEXT = "#FFE06C2A";
        public const string DARK_BACKGROUND = "#FF232020";
        public const string DARK_CONTROLS = "#FF5D5656";

        private string name;


        public Theme(string name)
        {
            this.name = name;
        }


        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Create color to assign to color properites of WPF controls(e.g., Background)
        /// </summary>
        /// <param name="color">Initial color to create brush</param>
        /// <returns>Color brush requested</returns>
        public static System.Windows.Media.Brush CreateBrush(string color)
        {
            var converter = new System.Windows.Media.BrushConverter();

            try
            {
                return (System.Windows.Media.Brush)converter.ConvertFrom(color);
            }
            catch
            {
                return null;
            }
        }
    }
}
