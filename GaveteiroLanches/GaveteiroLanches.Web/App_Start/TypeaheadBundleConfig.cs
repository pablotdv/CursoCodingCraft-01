using System.Web.Optimization;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(GaveteiroLanches.Web.App_Start.TypeaheadBundleConfig), "RegisterBundles")]

namespace GaveteiroLanches.Web.App_Start
{
	public class TypeaheadBundleConfig
	{
		public static void RegisterBundles()
		{
			// Add @Scripts.Render("~/bundles/typeahead") after jQuery in your _Layout.cshtml view
			// When <compilation debug="true" />, MVC 5 will render the full readable version. When set to <compilation debug="false" />, the minified version will be rendered automatically
			
		}
	}
}
