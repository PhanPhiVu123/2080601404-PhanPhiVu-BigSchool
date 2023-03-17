using System.Web;
using System.Web.Mvc;

namespace _2080601404_PhanPhiVu_BigSchool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
