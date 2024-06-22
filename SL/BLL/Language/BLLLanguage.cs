using SL.DAL.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.Language
{
  
		internal sealed class BLLLanguage
		{
			private readonly static BLLLanguage _instance = new BLLLanguage();

			public static BLLLanguage Current
			{
				get
				{
					return _instance;
				}
			}

			private BLLLanguage()
			{
				//Implent here the initialization of your singleton
			}

      
		public string Traducir(string palabra)
        {
            return DALLanguage.Current.Traducir(palabra);
        }
    }


		

	
}
