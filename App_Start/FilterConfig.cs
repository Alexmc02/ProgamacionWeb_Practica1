using System.Web;
using System.Web.Mvc;

namespace ProgamacionWeb_Practica1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
