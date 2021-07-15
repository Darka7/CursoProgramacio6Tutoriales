using BD;
using Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface ICatalogoCantonService
    {
        Task<IEnumerable<CatalogoCantonEntity>> GetLista();
    }

    public class CatalogoCantonService : ICatalogoCantonService
    {

        private readonly IDataAccess sql;

        public CatalogoCantonService(IDataAccess _sql)
        {
            sql = _sql;
        }

        public async Task<IEnumerable<CatalogoCantonEntity>> GetLista()
        {
            try
            {
                var result = sql.QueryAsync<CatalogoCantonEntity, CatalogoProvinciaEntity>("CatalogoCantonLista", "IdCatalogoCanton, IdCatalogoProvincia");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }


}
