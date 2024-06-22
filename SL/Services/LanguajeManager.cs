using SL.BLL.Language;
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
            
         
        }
        #endregion

       


        public string Traducir(string palabra)
        {
            return BLLLanguage.Current.Traducir(palabra);
        }


    }
}
