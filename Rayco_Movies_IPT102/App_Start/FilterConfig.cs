using System.Web;
using System.Web.Mvc;

namespace Rayco_Movies_IPT102
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
