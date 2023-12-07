using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SL.Services
{
    internal sealed class LanguageManager
    {
        #region Singleton
        private readonly static LanguageManager _instance = new LanguageManager();

        public static LanguageManager Current
        {
            get
            {
                return _instance;
            }
        }

        private LanguageManager()
        {
            filePath = @"I18n\idioma.";
        }
        #endregion

        private string filePath = String.Empty;

        public string Translate(string key)
        {
            string translatedWord = key;

            string culturaCodigo = Thread.CurrentThread.CurrentUICulture.Name;

            using (StreamReader streamReader = new StreamReader(filePath + culturaCodigo))
            {
                while (!streamReader.EndOfStream)
                {
                    string linea = streamReader.ReadLine();
                    string[] keyValuePair = linea.Split(':');

                    if (keyValuePair[0].ToLower() == key.ToLower())
                    {
                        translatedWord = keyValuePair[1];
                        break;
                    }
                }
            }

            return translatedWord;
        }

    }
}
