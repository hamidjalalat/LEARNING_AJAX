namespace LEARNING_AJAX.Controllers
{
	public class StepByStepController : System.Web.Mvc.Controller
	{
		public StepByStepController()
		{
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn01()
		{
			return (View());
		}

		//[System.Web.Mvc.HttpGet]
		//public System.Web.Mvc.JsonResult GetData01()
		//{
		//	return (Json(data: "Hello World!",
		//		behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		//}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult GetData01()
		{
			// Solution (1)
			//Models.MessageClass obj =
			//	new Models.MessageClass();

			//obj.Message = "Hello World!";

			//return (Json(data: obj,
			//	behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
			// Solution (1)

			// Solution (2)
			return (Json(data: new { Message = "Hello World!" },
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
			// Solution (2)
		}

		//[System.Web.Mvc.HttpGet]
		//public System.Web.Mvc.ContentResult GetData01()
		//{
		//	// Wrong Result
		//	//string strResult =
		//	//	"{'Message':'Hello World!'}";

		//	string strResult =
		//		"{\"Message\":\"Hello World!\"}";

		//	return (Content(strResult));
		//}

		//[System.Web.Mvc.HttpGet]
		//public string GetData01()
		//{
		//	string strResult =
		//		"{\"Message\":\"Hello World!\"}";

		//	return (strResult);
		//}

		//[System.Web.Mvc.HttpGet]
		//public string GetData01()
		//{
		//	Models.Customer oCustomer =
		//		new Models.Customer();

		//	oCustomer.Age = 20;
		//	oCustomer.FullName = "Ali Reza Alavi";

		//	string strResult =
		//		string.Format("{\"FullName\":\"{0}\";\"Age\":\"{1}\"}",
		//		oCustomer.FullName, oCustomer.Age);

		//	return (strResult);
		//}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn02()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData02()
		{
			return (Json(data: new { Message = "Hello World!" },
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn03()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData03()
		{
			System.Threading.Thread.Sleep(5000);
            

			return (Json(data: new { FullName = "Dariush Tasdighi", Age = 40 },
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn04()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData04()
		{
			System.Threading.Thread.Sleep(5000);

			return (Json(data: new { FullName = "Dariush Tasdighi", Age = 40 },
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn05()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData05_1(string fullName, int age)
		{
			System.Threading.Thread.Sleep(5000);

			// ***************************************************
			// *** اطلاعات را در بانک اطلاعاتی ذخيره می کنيم ***
			// ***************************************************
			//Models.Customer oCustomer =
			//	new Models.Customer();

			//oCustomer.Age = age;
			//oCustomer.FullName = fullName;

			//MyDatabaseContext.Customers.Add(oCustomer);

			//MyDatabaseContext.SaveChanges();
			// ****************************************************
			// *** /اطلاعات را در بانک اطلاعاتی ذخيره می کنيم ***
			// ****************************************************

			string strMessage =
				string.Format("I'm {0} and {1} years old.",
				fullName, age);

			return (Json(data: new { Message = strMessage },
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData05_2(string FullName, int Age)
		{
			System.Threading.Thread.Sleep(5000);

			string strMessage =
				string.Format("I'm {0} and {1} years old.",
				FullName, Age);

			return (Json(data: new { Message = strMessage },
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData05_3(Models.Customer customer)
		{
			System.Threading.Thread.Sleep(5000);

			string strMessage =
				string.Format("I'm {0} and {1} years old.",
				customer.FullName, customer.Age);

			return (Json(data: new { Message = strMessage },
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn06()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData06(double salary)
		{
			System.Threading.Thread.Sleep(5000);

			return (Json(data: new { Message = "Done!", },
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn07()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData07(Models.Customer customer)
		{
			System.Threading.Thread.Sleep(5000);

			string strMessage =
				string.Format("I'm {0} and {1} years old.",
				customer.FullName, customer.Age);

			return (Json(data: new { Message = strMessage },
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn08()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.PartialViewResult GetData08(string feeling)
		{
			System.Threading.Thread.Sleep(5000);

			//return (PartialView(model: customer));

			return (PartialView(viewName: "_Partial_GetData08", model: feeling));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn09()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData09(Models.Customer customer)
		{
			System.Threading.Thread.Sleep(5000);

			string strMessage =
				string.Format("I'm {0} and {1} years old.",
				customer.FullName, customer.Age);

			return (Json(new { Message = strMessage },
				System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn10()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData10(Models.Customer customer)
		{
			System.Threading.Thread.Sleep(5000);

			string strMessage =
				string.Format("I'm {0} and {1} years old.",
				customer.FullName, customer.Age);

			return (Json(new { Message = strMessage },
				System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		// **************************************************
		// **************************************************
		// **************************************************
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn11()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		//[System.Web.Mvc.OutputCache()]
		public System.Web.Mvc.PartialViewResult GetPartialViewForCreatingCustomer1()
		{
			System.Threading.Thread.Sleep(5000);

			return (PartialView(viewName: "_Partial_CreateCustomer1"));
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult SaveCustomer1(Models.Customer customer)
		{
			System.Threading.Thread.Sleep(5000);

			string strMessage =
				string.Format("I'm {0} and {1} years old.",
				customer.FullName, customer.Age);

			return (Json(new { Message = strMessage },
				System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn12()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.PartialViewResult GetPartialViewForCreatingCustomer2()
		{
			System.Threading.Thread.Sleep(5000);

			return (PartialView(viewName: "_Partial_CreateCustomer2"));
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult SaveCustomer2(Models.Customer customer)
		{
			System.Threading.Thread.Sleep(5000);

			string strMessage =
				string.Format("I'm {0} and {1} years old.",
				customer.FullName, customer.Age);

			return (Json(new { Message = strMessage },
				System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn13()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.PartialViewResult GetPartialViewForCreatingCustomer3()
		{
			System.Threading.Thread.Sleep(5000);

			return (PartialView(viewName: "_Partial_CreateCustomer3"));
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult SaveCustomer3(Models.Customer customer)
		{
			System.Threading.Thread.Sleep(5000);

			string strMessage =
				string.Format("I'm {0} and {1} years old.",
				customer.FullName, customer.Age);

			return (Json(new { Message = strMessage },
				System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn14()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.PartialViewResult GetPartialViewForCreatingCustomer4()
		{
			System.Threading.Thread.Sleep(5000);

			return (PartialView(viewName: "_Partial_CreateCustomer4"));
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult SaveCustomer4(Models.Customer customer)
		{
			System.Threading.Thread.Sleep(5000);

			string strMessage =
				string.Format("I'm {0} and {1} years old.",
				customer.FullName, customer.Age);

			return (Json(new { Message = strMessage },
				System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}
		// **************************************************
		// **************************************************
		// **************************************************
	}
}
