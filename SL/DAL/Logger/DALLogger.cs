using SL.DAL.Tools;
using SL.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.Logger
{

	internal sealed class DALLogger
	{
		private readonly static DALLogger _instance = new DALLogger();

		public static DALLogger Current
		{
			get
			{
				return _instance;
			}
		}

		private DALLogger()
		{
			//Implent here the initialization of your singleton
		}




        public void Write(string mensaje, EventLevel evento)
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


                    Task.Run(async () =>
                    {
                        await EnviarNotificacionCritica(evento);
                    }).Wait(); // Esperar a que la tarea asincrónica complete (sincronización de hilos)


                    break;

            }
        }
        private static async Task EnviarNotificacionCritica(EventLevel evento)
        {
            try
            {
                string messageText = $"Tienes un evento crítico del tipo {evento}";
                await TelegramManager.Current.SendMessage(messageText);
            }
            catch (Exception ex)
            {
                // Puedes manejar el error de la notificación de manera adecuada
                Console.WriteLine($"Error al enviar notificación crítica: {ex.Message}");
            }
        }
    }

}
