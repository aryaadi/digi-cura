using System.Web;
using System.Web.Mvc;

namespace Avam.DigiCura.NgOne.UI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
