using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTranslatorGrafica.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        private Models.ISettingsService settingsService;

        private Models.Theme selectedTheme;

        public SettingsViewModel(Models.ISettingsService settingsService)
        {
            this.settingsService = settingsService;

            IEnumerable<Models.Theme> result = settingsService.Themes.Where(t => t.Name == Properties.Settings.Default.Theme);
            this.selectedTheme = result.ElementAt<Models.Theme>(0);
        }

        public IList<Models.Theme> Themes { get { return settingsService.Themes; } }

        public Models.Theme SelectedTheme
        {
            get { return selectedTheme; }

            set
            {
                if (selectedTheme == null) return;

                selectedTheme = value;

                ////todo: refactor 
                if (selectedTheme.Name == "Dark")
                    Properties.Settings.Default.DarkTheme = true;
                else
                    Properties.Settings.Default.DarkTheme = false;

                Properties.Settings.Default.Theme = selectedTheme.Name;

                Properties.Settings.Default.Save();

                NotifyPropertyChanged();
            }
        }
    }
}
