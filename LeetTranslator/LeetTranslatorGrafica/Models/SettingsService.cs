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

            themes.Add(new Theme("Light"));
            themes.Add(new Theme("Dark"));
        }

        public IList<Theme> Themes => themes;
    }
}
