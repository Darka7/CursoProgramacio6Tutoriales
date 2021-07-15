using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CatalogoDistritoEntity
    {
        public CatalogoDistritoEntity()
        {

            Canton = Canton ?? new CatalogoCantonEntity();
        }

        public int? IdCatalogoDistrito { get; set; }
        public string NombreCatalogoDistrito { get; set; }
        public int? IdCatalogoCanton { get; set; }
        public virtual CatalogoCantonEntity Canton { get; set; }
    }
}
