using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace netsessions.Pages
{
    public class leggiModel : PageModel
    {
        public bool notexists { get; set; }
        public string msg { get; set; }
        public int info { get; set; }
        public void OnGet()
        {
            info = HttpContext.Session.Keys.Count();
            notexists = string.IsNullOrWhiteSpace(HttpContext.Session.GetString("Chiave"));

            if (notexists)
                msg = "Nessun valore di sessione";

          

        }
    }
}
