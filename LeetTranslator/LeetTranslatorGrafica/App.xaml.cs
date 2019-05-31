using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LeetTranslatorGrafica
{
    /// <summary>
    /// Logica di interazione per App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Models.ITranslationService service = new Models.TranslationService();

            Views.MainWindow mainWindow = new Views.MainWindow(new ViewModels.MainWindowViewModel(service));
            mainWindow.Show();
        }
    }
}
