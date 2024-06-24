using SL.BLL.Logger;
using SL.DAL.Logger;
using SL.DAL.Tools;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Services
{
    
		public class LoggerManager
		{
			private readonly static LoggerManager _instance = new LoggerManager();

			public static LoggerManager Current
			{
				get
				{
					return _instance;
				}
			}

			private LoggerManager()
			{
				//Implent here the initialization of your singleton
			}


        public void Write(string mensaje, EventLevel evento)
        {
            BLLLogger.Current.Write(mensaje, evento);

        }
    }

	
}