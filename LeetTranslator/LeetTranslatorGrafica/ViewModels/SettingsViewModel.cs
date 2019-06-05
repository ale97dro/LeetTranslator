﻿using System;
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

            Models.Theme theme = Models.Theme.Deserialize(Properties.Settings.Default.ThemeSer);
            //theme.Deserialize(Properties.Settings.Default.ThemeSer);

            IEnumerable<Models.Theme> result = settingsService.Themes.Where(t => t.Name == theme.Name);
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

                Properties.Settings.Default.ThemeSer = selectedTheme.Serialize();

                Properties.Settings.Default.Save();

                NotifyPropertyChanged();
            }
        }
    }
}
