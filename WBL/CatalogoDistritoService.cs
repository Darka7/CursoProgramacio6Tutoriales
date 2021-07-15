using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface ICatalogoDistritoService
    {
        Task<IEnumerable<CatalogoDistritoEntity>> GetLista();
    }

    public class CatalogoDistritoService : ICatalogoDistritoService
    {
        private readonly IDataAccess sql;

        public CatalogoDistritoService(IDataAccess _sql)
        {
            sql = _sql;
        }

        public async Task<IEnumerable<CatalogoDistritoEntity>> GetLista()
        {
            try
            {
                var result = sql.QueryAsync<CatalogoDistritoEntity, CatalogoCantonEntity>("CatalogoDistritoLista", "IdCatalogoDistrito, IdCatalogoCanton");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}

