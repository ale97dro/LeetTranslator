using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTranslatorGrafica.Models
{
    class SettingsService : ISettingsService
    {
        private List<Theme> themes;

        public SettingsService()
        {
            themes = new List<Theme>();

            themes.Add(new Theme("Light", ThemeColors.LIGHT_TEXT, ThemeColors.LIGHT_BACKGROUND, ThemeColors.LIGHT_CONTROLS));
            themes.Add(new Theme("Dark", ThemeColors.DARK_TEXT, ThemeColors.DARK_BACKGROUND, ThemeColors.DARK_CONTROLS));
        }

        public IList<Theme> Themes => themes;
    }
}
