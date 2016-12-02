using System.Web;
using System.Web.Mvc;

namespace Comp229_FinalTeamProject
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
