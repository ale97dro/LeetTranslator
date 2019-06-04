using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
       // private bool writeOnFile;

        /// <summary>
        /// Alphabet selected by the user for the translation
        /// </summary>
        private Models.Alphabet selectedAlphabet;

        public MainWindowViewModel(Models.ITranslationService service)
        {
            this.tranlationService = service;
            this.selectedAlphabet = service.Alphabets[0];
            //writeOnFile = false;
        }


        //public bool WriteOnFile
        //{
        //    get { return writeOnFile; }

        //    set
        //    {
        //        writeOnFile = value;
        //        NotifyPropertyChanged();
        //    }
        //}

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


        /**** REAL METHOD TO PERFORM ACTIONS ****/

        /// <summary>
        /// Translate the text submitted by the user.
        /// Create a new translator with the choosen alphabet and start the translation.
        /// </summary>
        /// <param name="plainText">Text written by the user</param>
        /// <returns>Leet text as result of the translation</returns>
        public string Translate(string plainText)
        {
            Models.ITranslate trans = new Models.LeetTranslator(selectedAlphabet);

            return tranlationService.ExecuteService(plainText, trans);
        }

        public void ExportTextFile(string text)
        {
            string path;

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text file | *txt";
            dialog.DefaultExt = ".txt";
            dialog.AddExtension = true;

            if ((bool)dialog.ShowDialog())
            {
                path = dialog.FileName;
                Models.WriteTranslation.WriteOnFile(text, path);

                Process.Start(path);
            }
        }

        public SettingsViewModel Settings()
        {
            Models.ISettingsService service = new Models.SettingsService();

            return new SettingsViewModel(service);
        }
    }
}
