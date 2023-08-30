using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace netsessions.Classi
{
    public class Controlli
    {
        public static bool Empty(string v)
        {
            if(string.IsNullOrEmpty(v)) 
                return false;
            return true;
        }
    }
}
