namespace LEARNING_AJAX
{
	public class MvcApplication : System.Web.HttpApplication
	{
		public MvcApplication()
			: base()
		{
		}

		protected void Application_Start()
		{
			System.Web.Mvc.AreaRegistration.RegisterAllAreas();

			System.Web.Mvc.ModelBinders.Binders.Add
				(typeof(double), new Infrastructure.DoubleModelBinder());

			RouteConfig.RegisterRoutes(System.Web.Routing.RouteTable.Routes);
		}
	}
}
