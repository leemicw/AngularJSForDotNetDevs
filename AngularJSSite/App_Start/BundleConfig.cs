using System.Web;
using System.Web.Optimization;

namespace AngularJSSite
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles) {

			bundles.Add(new ScriptBundle("~/jsBundles/ShellPageContent").Include(
					  "~/Scripts/Angular.js",
					  "~/Scripts/Angular-route.js",
					  "~/Angular/app.js",
					  "~/Angular/Controllers/*Controller.js",
					  "~/Angular/Factories/*Factory.js",
					  "~/Angular/Services/*Service.js"
					  ));

			bundles.Add(new StyleBundle("~/cssBundles/ShellPage").Include(
					  "~/Content/Css/reset.css",
					  "~/Content/Css/site.css"));

			//BundleTable.EnableOptimizations = true;
		}
	}
}
