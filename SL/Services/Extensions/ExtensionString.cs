﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Services.Extensions
{
    public static class ExtensionString
    {
        /// <summary>
        /// NO OLVIDAR LOS SUMMARY
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string Traducir(this string palabra)
        {
            return LanguageManager.Current.Traducir(palabra);
        }
    }
}
