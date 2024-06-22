using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;

namespace SL.DAL.Language
{
    
		internal sealed class DALLanguage
		{
			private readonly static DALLanguage _instance = new DALLanguage();

			public static DALLanguage Current
			{
				get
				{
					return _instance;
				}
			}

			private DALLanguage()
			{
				filePath = ConfigurationManager.AppSettings["Lenguaje"];
			}


        private string filePath = String.Empty;


        public string Traducir(string palabra)
        {
            string translatedWord = palabra;

            string culturaCodigo = Thread.CurrentThread.CurrentUICulture.Name;

            using (StreamReader streamReader = new StreamReader(filePath + culturaCodigo))
            {
                while (!streamReader.EndOfStream)
                {
                    string linea = streamReader.ReadLine();
                    string[] keyValuePair = linea.Split(':');

                    if (keyValuePair[0].ToLower() == palabra.ToLower())
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
