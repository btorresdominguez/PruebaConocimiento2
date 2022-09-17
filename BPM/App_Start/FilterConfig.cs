using System.Web;
using System.Web.Mvc;

namespace BPM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
           // filters.Add(new Filters.VerifySession());
        }
    }
}
