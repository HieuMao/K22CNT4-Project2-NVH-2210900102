using System.Web;
using System.Web.Mvc;

namespace K22CNT4_TTCD_Nguyễn_Văn_Hiếu_2210900102
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
