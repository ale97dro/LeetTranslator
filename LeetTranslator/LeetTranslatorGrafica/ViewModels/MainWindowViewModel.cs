using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LeetTranslatorGrafica.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        /// <summary>
        /// Service that perform the translation to leet
        /// </summary>
        private Models.ITranslationService tranlationService;

        /// <summary>
        /// Write the result on file or not
        /// </summary>
        private bool writeOnFile;

        /// <summary>
        /// Alphabet selected by the user for the translation
        /// </summary>
        private Models.Alphabet selectedAlphabet;

        public MainWindowViewModel(Models.ITranslationService service)
        {
            this.tranlationService = service;
            this.selectedAlphabet = service.Alphabets[0];
            writeOnFile = false;
        }


        public bool WriteOnFile
        {
            get { return writeOnFile; }

            set
            {
                writeOnFile = value;
                NotifyPropertyChanged();
            }
        }

        public IList<Models.Alphabet> Alphabets
        {
            get { return tranlationService.Alphabets; }
        }

        public Models.Alphabet SelectedAlphabet
        {
            get { return selectedAlphabet; }

            set
            {
                if (selectedAlphabet == null) return;

                selectedAlphabet = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Translate the text submitted by the user.
        /// Create a new translator with the choosen alphabet and start the translation.
        /// </summary>
        /// <param name="plainText">Text written by the user</param>
        /// <returns>Leet text as result of the translation</returns>
        public string Translate(string plainText)
        {
            Models.ITranslate trans = new Models.LeetTranslator(selectedAlphabet);

            return tranlationService.ExecuteService(plainText, trans, writeOnFile);
        }

        public SettingsViewModel Settings()
        {
            Models.ISettingsService service = new Models.SettingsService();

            return new SettingsViewModel(service);
        }
    }
}
