using SL.DAL.Logger;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.Logger
{

	internal sealed class BLLLogger
	{
		private readonly static BLLLogger _instance = new BLLLogger();

		public static BLLLogger Current
		{
			get
			{
				return _instance;
			}
		}

		private BLLLogger()
		{
			//Implent here the initialization of your singleton
		}

        public void Write(string mensaje, EventLevel evento)
        {
			DALLogger.Current.Write(mensaje, evento);

        }
    }

}
