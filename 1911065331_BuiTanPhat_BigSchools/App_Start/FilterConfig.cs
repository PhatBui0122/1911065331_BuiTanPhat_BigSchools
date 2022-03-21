using System.Web;
using System.Web.Mvc;

namespace _1911065331_BuiTanPhat_BigSchools
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
