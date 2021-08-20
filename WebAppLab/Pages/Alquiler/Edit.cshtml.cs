using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebAppLab.Pages.Alquiler
{
    public class EditModel : PageModel
    {
        private readonly IAlquilerService alquilerService;
        private readonly IClientesService clientesService;
        private readonly IVehiculoService vehiculoService;


        public EditModel(IAlquilerService alquilerService, IClientesService clientesService,
            IVehiculoService vehiculoService)
        {
            this.alquilerService = alquilerService;
            this.clientesService = clientesService;
            this.vehiculoService = vehiculoService;

        }


        [BindProperty]
        [FromBody]
        public AlquilerEntity Entity { get; set; } = new AlquilerEntity(); 
        public void OnGet()
        {
        }
    }
}
