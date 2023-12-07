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
    internal class FamiliaRepository : IGenericRepository<Familia>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Familia] (IdFamilia, Nombre) VALUES (@IdFamilia, @Nombre)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Familia] SET (IdFamilia = @IdFamilia, Nombre = @Nombre) WHERE IdFamilia = @IdFamilia";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Familia] WHERE IdFamilia = @IdFamilia";
        }

        private string SelectOneStatement
        {
            get => "SELECT IdFamilia, Nombre FROM [dbo].[Familia] WHERE IdFamilia = @IdFamilia";
        }

        private string SelectAllStatement
        {
            get => "SELECT IdFamilia, Nombre FROM [dbo].[Familia]";
        }
        #endregion


        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Familia> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Familia GetOne(Guid id)
        {
            Familia familia = default;

            try
            {
                using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text,
                                                        new SqlParameter[] { new SqlParameter("@IdFamilia", id) }))
                {
                    if (dr.Read())
                    {
                        //En este caso tendremos un solo registro...
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);

                        familia = FamiliaAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(this, ex);
            }
            return familia;
        }

        public void Insert(Familia obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Familia obj)
        {
            throw new NotImplementedException();
        }
    }
}
