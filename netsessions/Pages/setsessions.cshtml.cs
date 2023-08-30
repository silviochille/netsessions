using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using netsessions.Classi;
using Microsoft.AspNetCore.Http;

namespace netsessions.Pages.Shared
{
    public class setsessionsModel : PageModel
    {
        public string msg { get; set; }
       
        public void OnGet()
        {
            msg = "Messaggio";
          

        }


        public void OnPost() 
        {

            string val = Request.Form["sessionv"];

            if (!Controlli.Empty(val))
                msg = "Riempi il campo";

            else
            {
                int kn = Count.Value;
               
                HttpContext.Session.SetString("Chiave"+kn, val);

                Count.Value++;
                 msg = "Valore settato";
            }

        }
    }
}
