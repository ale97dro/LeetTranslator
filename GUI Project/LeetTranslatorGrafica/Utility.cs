using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTranslatorGrafica
{
    public class Utility
    {
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
