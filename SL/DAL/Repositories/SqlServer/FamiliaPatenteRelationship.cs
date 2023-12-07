using SL.DAL.Contracts;
using SL.DAL.Tools;
using SL.Domain.SecurityComposite;
using SL.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.Repositories.SqlServer
{
    internal class FamiliaPatenteRelationship : IGenericRelationship<Familia, Patente>
    {
        public List<Patente> Get(Familia obj)
        {
            //Familia_Patente_Select
            //GUID EN EL CASO DE QUE UTILICEN uniqueidentifier
            string IdFamilia = obj.IdFamilia.ToString();
            List<Patente> patentes = new List<Patente>();

            try
            {
                using (var dr = SqlHelper.ExecuteReader("Familia_Patente_Select", System.Data.CommandType.StoredProcedure,
                                                       new SqlParameter[] { new SqlParameter("@IdFamilia", IdFamilia) }))
                {
                    //Cada read equivale a leer una relación de mi familia con una patente...
                    while (dr.Read())
                    {
                        //Tengo una nueva patente relacionada...
                        Guid idPatente = Guid.Parse(dr.GetString(1)); //Tengo el id de la patente en la columna nro 1

                        Patente patente = new PatenteRepository().GetOne(idPatente);

                        patentes.Add(patente);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(this, ex);
            }

            return patentes;
        }

        public void Join(Familia obj1, Patente obj2)
        {
            throw new NotImplementedException();
        }
    }
}
