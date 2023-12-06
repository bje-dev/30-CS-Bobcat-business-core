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

        public async Task Write(string mensaje, EventLevel evento)
        {
            DateTime fecha = DateTime.Now;

            switch (evento)
            {
               
                case EventLevel.Informational:
               
                    
                    try
                    {
                        SqlParameter[] parameters = new SqlParameter[]
                        {
                    new SqlParameter("@fecha",fecha),
                    new SqlParameter("@evento",evento),
                    new SqlParameter("@mensaje",mensaje),
                 
                        };

                        int rowsAffected = SqlHelper.ExecuteNonQuery("INSERT INTO [dbo].[Bitacora] (fecha, evento, mensaje) VALUES (@fecha, @evento, @mensaje)", System.Data.CommandType.Text, parameters);

                       
                    }
                    catch (SqlException ex)
                    {
                        throw new ApplicationException("Ocurrió un error interno del servidor al registrar la bitacora. Por favor, contacte al soporte técnico.", ex);
                    }
                    break;


                case EventLevel.Critical:

                    
                    try
                    {
                        SqlParameter[] parameters = new SqlParameter[]
                        {
                    new SqlParameter("@fecha",fecha),
                    new SqlParameter("@evento",evento),
                    new SqlParameter("@mensaje",mensaje),

                        };

                        int rowsAffected = SqlHelper.ExecuteNonQuery("INSERT INTO [dbo].[Bitacora] (fecha, evento, mensaje) VALUES (@fecha, @evento, @mensaje)", System.Data.CommandType.Text, parameters);


                        

                    }
                    catch (SqlException ex)
                    {
                        throw new ApplicationException("Ocurrió un error interno del servidor al registrar la bitacora. Por favor, contacte al soporte técnico.", ex);
                    }


                    string messageText = $"Tenes un evento critico del tipo {evento}";

                    
                    await TelegramManager.Current.SendMessage(messageText);



                    break;

            }
        }

    }

	
}