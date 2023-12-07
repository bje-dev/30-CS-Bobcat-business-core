using SL.DAL.Contracts;
using SL.DAL.Repositories.SqlServer.Adapters;
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
    internal class PatenteRepository : IGenericRepository<Patente>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Patente] (IdPatente, Nombre, Vista) VALUES (@IdPatente, @Nombre, @Vista)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Patente] SET (IdPatente = @IdPatente, Nombre = @Nombre, Vista = @Vista) WHERE IdPatente = @IdPatente";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Patente] WHERE IdPatente = @IdPatente";
        }

        private string SelectOneStatement
        {
            get => "SELECT IdPatente, Nombre, Vista FROM [dbo].[Patente] WHERE IdPatente = @IdPatente";
        }

        private string SelectAllStatement
        {
            get => "SELECT IdPatente, Nombre, Vista FROM [dbo].[Patente]";
        }
        #endregion

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Patente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Patente GetOne(Guid id)
        {
            Patente patente = default;

            try
            {
                using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text,
                                                        new SqlParameter[] { new SqlParameter("@IdPatente", id) }))
                {
                    if (dr.Read())
                    {
                        //En este caso tendremos un solo registro...
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);

                        patente = PatenteAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(this, ex);
            }
            return patente;
        }

        public void Insert(Patente obj)
        {
            try
            {
                obj.IdPatente = Guid.NewGuid(); //Buscar en la librería nativa de sql server, 
                                                //la posibilidad de utilizar newSequentialGuid desde c#
                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text,
               new SqlParameter[] { new SqlParameter("@IdPatente", obj.IdPatente),
                                     new SqlParameter("@Nombre", obj.Nombre),
                                     new SqlParameter("@Vista", obj.Vista)});
            }
            catch (Exception ex)
            {
                obj.IdPatente = default; //null en Guid -> Completa con 0
                ExceptionManager.Current.Handle(this, ex);
            }
        }

        public void Update(Patente obj)
        {
            throw new NotImplementedException();
        }
    }
}
