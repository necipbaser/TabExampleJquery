using System.Web;
using System.Web.Mvc;

namespace Asp.Net_Mvc_Tab_Example_with_Jquery
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
