using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppLab.Pages.MarcaVehiculo
{
    public class EditModel : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public int? id { get; set; }
        public void OnGet()
        {
        }
    }
}
