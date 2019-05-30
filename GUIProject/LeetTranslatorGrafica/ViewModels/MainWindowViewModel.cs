using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTranslatorGrafica.ViewModels
{
    /// <summary>
    /// This application doesn't present a conventional model: the information on which it works are provided at runtime by the user so this is a particular type of ViewModel.
    /// </summary>
    public class MainWindowViewModel : BaseViewModel
    {
        private Models.ITranslationService service;

        public MainWindowViewModel(Models.ITranslationService service)
        {
            this.service = service;
        }

        public string Translate(string plainText, Models.ITranslate translator, bool writeOnFile)
        {
            return service.ExecuteService(plainText, translator, writeOnFile);
        }
    }
}
