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
    public class GridModel : PageModel
    {
        private readonly IAgenciaService agenciaService;

        public GridModel(IAgenciaService agenciaService)
        {
            this.agenciaService = agenciaService;
        }

        public IEnumerable<AgenciaEntity> GridList { get; set; } = new List<AgenciaEntity>();

        public string Mensaje { get; set; } = "";
        public async Task<IActionResult> OnGet()
        {
            try
            {
                GridList = await agenciaService.Get();

                if (TempData.ContainsKey("Msg"))
                {
                    Mensaje = TempData["Msg"].ToString();

                }
                TempData.Clear();
                return Page();


            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        public async Task<IActionResult> OnGetEliminar(int id)
        {
            try
            {
                var result = await agenciaService.Delete(new()
                {
                    AgenciaId = id
                });

                if (result.CodeError != 0)
                {
                    throw new Exception(result.MsgError);
                }

                Mensaje = "Se elimino correctamente";


                TempData["Msg"] = "Se elimino correctamente";

                return Redirect("Grid");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }
    }
}

