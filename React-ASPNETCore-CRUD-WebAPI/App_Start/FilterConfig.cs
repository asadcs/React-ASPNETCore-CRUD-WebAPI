using System.Web;
using System.Web.Mvc;

namespace React_ASPNETCore_CRUD_WebAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
