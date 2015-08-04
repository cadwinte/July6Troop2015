using System.Web;
using System.Web.Mvc;

namespace AngularJSDay21.Events
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
