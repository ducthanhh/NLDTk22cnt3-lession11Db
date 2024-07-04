using System.Web;
using System.Web.Mvc;

namespace NLDTk22cnt3_lession111DB_2210900065
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
