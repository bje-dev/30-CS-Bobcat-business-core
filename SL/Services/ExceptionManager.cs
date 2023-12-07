using SL.Services.Custom;
using SL.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Services
{
    public sealed class ExceptionManager
    {
        #region Singleton
        private readonly static ExceptionManager _instance = new ExceptionManager();

        public static ExceptionManager Current
        {
            get
            {
                return _instance;
            }
        }

        private ExceptionManager()
        {
            //Implement here the initialization code
        }
        #endregion

        private string DALComponent = ConfigurationManager.AppSettings["DALComponent"];
        private string BLLComponent = ConfigurationManager.AppSettings["BLLComponent"];
        private string UIComponent = ConfigurationManager.AppSettings["UIComponent"];

        public void Handle(object sender, Exception ex)
        {
            string assemblyName = sender.GetType().Assembly.GetName().Name;

            if (assemblyName == UIComponent)
                UIHandle(ex);
            else if (assemblyName == BLLComponent)
                BLLHandle(ex);
            else if (assemblyName == DALComponent)
                DALHandle(ex);
            else
                throw new Exception("No se conoce el source para gestión de errores");
        }

        private void UIHandle(Exception ex)
        {
            //Aplico políticas para el manejo de exceptions desde la UI
            if (ex.Source == "Consola")
                WritePolicy(ex);
        }

        private void BLLHandle(Exception ex)
        {
            //¿Cómo sé que la exception fue lanzada previamente en DAL?
            if (ex.InnerException != null)
            {
                //Envolver una exception
                throw new Exception("No se puede acceder al servidor de BD en este momento".Traducir(), ex);
            }
            else
            {
                if (ex is BusinessException)
                {
                    //APLICAR POLÍTICA DE EXCEPCIONES DEL NEGOCIO...
                    //Política -> 1) Registrar 2) Relanzar la excepción
                    WritePolicy(ex); //Verificar la posibilidad de persistir las excepciones de negocio en una DB u otro archivo...
                    throw ex;
                }
                else
                {
                    //APLICAR POLÍTICA DE EXCEPCIONES NO CONTROLADAS...
                    //Política-> 1) Registrar 2) Envolver y Lanzar la excepción
                    WritePolicy(ex);
                    throw new Exception("Ha ocurrido un error inesperado".Traducir(), ex);
                }
            }
        }

        private void DALHandle(Exception ex)
        {
            //Aplico políticas para el manejo de exceptions desde la DAL
            WritePolicy(ex);
            throw new Exception("DAL Exception", ex);
        }

        private void WritePolicy(Exception ex)
        {
            LoggerManager.Current.Write($"Message: {ex.Message}, StackTrace: {ex.StackTrace}", System.Diagnostics.Tracing.EventLevel.Error);
        }
    }
}
