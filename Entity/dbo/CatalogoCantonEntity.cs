using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CatalogoCantonEntity
    {
        public CatalogoCantonEntity()
        {

            Provincia = Provincia ?? new CatalogoProvinciaEntity();
        }

        public int? IdCatalogoCanton { get; set; }

        public string NombreCatalogoCanton { get; set; }
        public int? IdCatalogoProvincia { get; set; }
        public virtual CatalogoProvinciaEntity Provincia { get; set; }
    }
}
