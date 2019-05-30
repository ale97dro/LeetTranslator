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
        //public Command.RelayCommand TranslateCommand { get; private set; }

        private bool writeOnFile;
        private bool lightLeet;
        private bool completeLeet;

        public MainWindowViewModel(Models.ITranslationService service)
        {
            this.tranlationService = service;

            writeOnFile = false;
            lightLeet = true;
            completeLeet = false;
            //TranslateCommand = new Command.RelayCommand(TranslateMethod, TranslateCanExec);
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

        public bool LightLeet
        {
            get
            {
                return lightLeet;
            }

            set
            {
                lightLeet = value;
                NotifyPropertyChanged();
            }
        }

        public bool CompleteLeet
        {
            get
            {
                return completeLeet;
            }

            set
            {
                completeLeet = value;
                NotifyPropertyChanged();
            }
        }


        //private void TranslateMethod(object param)
        //{
        //    Translate(null, null, true);
        //}

        //private bool TranslateCanExec(object param)
        //{
        //    return true;
        //}

        public string Translate(string plainText)
        {
            Models.ITranslate trans;

            if (lightLeet)
                trans = new Models.LighLeetTranslator();
            else
                trans = new Models.CompleteLeetTranslator();
                

            return tranlationService.ExecuteService(plainText, trans, writeOnFile);
        }
    }
}
