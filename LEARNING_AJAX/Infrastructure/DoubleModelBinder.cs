namespace Infrastructure
{
	public class DoubleModelBinder : System.Web.Mvc.IModelBinder
	{
		public DoubleModelBinder()
			: base()
		{
		}

		//public object BindModel
		//	(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext)
		//{
		//	throw new System.NotImplementedException();
		//}

		public object BindModel
			(System.Web.Mvc.ControllerContext controllerContext,
			System.Web.Mvc.ModelBindingContext bindingContext)
		{
			System.Web.Mvc.ValueProviderResult oValueResult =
				bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

			System.Web.Mvc.ModelState modelState =
				new System.Web.Mvc.ModelState { Value = oValueResult };

			System.Globalization.CultureInfo oCultureInfo =
				new System.Globalization.CultureInfo("en-US");

			oCultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";

			object oActualValue = null;

			try
			{
				oActualValue =
					System.Convert.ToDouble
						(oValueResult.AttemptedValue, oCultureInfo);
			}
			catch (System.FormatException e)
			{
				modelState.Errors.Add(e);
			}

			bindingContext.ModelState.Add(bindingContext.ModelName, modelState);

			return (oActualValue);
		}
	}
}
