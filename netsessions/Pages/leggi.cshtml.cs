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

      

      

        public List<string> valoris = new List<string>();
        public void OnGet()
        {
            info = HttpContext.Session.Keys.Count();
            if(info == 0)
            notexists = false;
            else notexists = true;  

            if (!notexists)
                msg = "Nessun valore di sessione";

            else
            {


                foreach (var key in HttpContext.Session.Keys.ToList())
                {

                     valoris.Add(HttpContext.Session.GetString(key));
                    Console.WriteLine(key);
                }

                Console.WriteLine("bbb");
                
            }

          

        }
    }
}
