using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebAppLab.Pages.Agencia
{
    public class EditModel : PageModel
    {
        private readonly IAgenciaService agenciaService;
        private readonly ICatalogoProvinciaService catalogoProvinciaService ;
        private readonly ICatalogoCantonService catalogoCantonService;
        private readonly ICatalogoDistritoService catalogoDistritoService;



        public EditModel(IAgenciaService agenciaService, ICatalogoProvinciaService catalogoProvinciaService, ICatalogoCantonService catalogoCantonService, ICatalogoDistritoService catalogoDistritoService)
        {
            this.agenciaService = agenciaService;
            this.catalogoProvinciaService = catalogoProvinciaService;
            this.catalogoCantonService = catalogoCantonService;
            this.catalogoDistritoService = catalogoDistritoService;

        }

        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }

        [BindProperty]
        public AgenciaEntity Entity { get; set; } = new AgenciaEntity();

        public IEnumerable<CatalogoProvinciaEntity> ProvinciaLista { get; set; } = new List<CatalogoProvinciaEntity>();
        public IEnumerable<CatalogoCantonEntity> CantonLista { get; set; } = new List<CatalogoCantonEntity>();
        public IEnumerable<CatalogoDistritoEntity> DistritoLista { get; set; } = new List<CatalogoDistritoEntity>();


        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await agenciaService.GetById(new() { AgenciaId = id });
                }

                ProvinciaLista = await catalogoProvinciaService.GetLista();
                CantonLista = await catalogoCantonService.GetLista();
                DistritoLista = await catalogoDistritoService.GetLista();



                return Page();

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                if (Entity.AgenciaId.HasValue)
                {
                    //Actualizar
                    var result = await agenciaService.Update(Entity);

                    if (result.CodeError != 0) throw new Exception(result.MsgError);

                    TempData["Msg"] = "Se actualizó Correctamente";
                }
                else
                {
                    //Nuevo
                    var result = await agenciaService.Create(Entity);

                    if (result.CodeError != 0) throw new Exception(result.MsgError);

                    TempData["Msg"] = "Se agrego Correctamente";
                }

                return RedirectToPage("Grid");


            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }



        }
    }
}
