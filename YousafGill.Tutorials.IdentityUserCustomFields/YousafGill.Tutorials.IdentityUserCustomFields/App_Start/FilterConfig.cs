using System.Web;
using System.Web.Mvc;

namespace YousafGill.Tutorials.IdentityUserCustomFields
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
