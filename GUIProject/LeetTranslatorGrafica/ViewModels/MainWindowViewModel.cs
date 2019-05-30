using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTranslatorGrafica.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private Models.ITranslationService tranlationService;

        private bool writeOnFile;

        private Models.Alphabet selectedAlphabet;

        public MainWindowViewModel(Models.ITranslationService service)
        {
            this.tranlationService = service;
            this.selectedAlphabet = service.Alphabets[0];
            writeOnFile = false;
        }


        public bool WriteOnFile
        {
            get
            {
                return writeOnFile;
            }

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
                //NotifyPropertyChanged();
            }
        }

        public string Translate(string plainText)
        {
            Models.ITranslate trans = new Models.LeetTranslator(selectedAlphabet);

            return tranlationService.ExecuteService(plainText, trans, writeOnFile);
        }
    }
}
