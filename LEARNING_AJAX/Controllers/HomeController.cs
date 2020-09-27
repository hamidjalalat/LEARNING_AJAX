using System.Linq;

namespace LEARNING_AJAX.Controllers
{
	public class HomeController : System.Web.Mvc.Controller
	{
		public HomeController()
		{
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ActionResult Index()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn01()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn02()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.PartialViewResult GetPartialView01()
		{
			//return (PartialView());
			return (PartialView(viewName: "_PartialView01"));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn03()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn04()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.PartialViewResult GetPartialView02()
		{
			System.Threading.Thread.Sleep(5000);

			return (PartialView("_PartialView02"));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn05()
		{
			return (View());
		}

		//[System.Web.Mvc.HttpPost]
		//public System.Web.Mvc.PartialViewResult GetPartialView03()
		//{
		//	string strData = Request.Form["data"];
		//	//string strData = Request.Params["data"];

		//	System.Threading.Thread.Sleep(5000);

		//	// اين متن را در داخل بانک اطلاعاتی ذخيره می‌کنيم

		//	ViewBag.Data = strData;

		//	return (PartialView("_PartialView03"));
		//}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.PartialViewResult GetPartialView03(string data)
		{
			System.Threading.Thread.Sleep(5000);

			// اين متن را در داخل بانک اطلاعاتی ذخيره می‌کنيم

			ViewBag.Data = data;

			return (PartialView("_PartialView03"));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn06()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn07()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.PartialViewResult GetPartialView04(string data)
		{
			System.Threading.Thread.Sleep(5000);

			// اين متن را در داخل بانک اطلاعاتی ذخيره می‌کنيم

			ViewBag.Data = data;
			ViewBag.Id = System.Guid.NewGuid();

			return (PartialView("_PartialView04"));
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.PartialViewResult Delete(System.Guid id)
		{
			System.Threading.Thread.Sleep(5000);

			// اطلاعات مورد را از بانک اطلاعاتی حذف می کنيم

			return (PartialView("_PartialView05"));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult GetJson01()
		{
			System.Threading.Thread.Sleep(5000);

			throw (new System.Exception("Unexpected Error!"));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult GetJson02()
		{
			System.Threading.Thread.Sleep(5000);

			string strMessage1 = "This is message (1)!";
			string strMessage2 = "This is message (2)!";

			// Solution (1)
			//SomeClass obj = new SomeClass();

			//obj.MyMessage1 = strMessage1;
			//obj.MyMessage2 = strMessage2;

			//return (Json(obj, System.Web.Mvc.JsonRequestBehavior.AllowGet));
			// /Solution (1)

			// Solution (2)
			return (Json(new { MyMessage1 = strMessage1, MyMessage2 = strMessage2 },
				System.Web.Mvc.JsonRequestBehavior.AllowGet));
			// /Solution (2)
		}

		[System.Web.Mvc.HttpGet]
		public string GetJson03()
		{
			System.Threading.Thread.Sleep(5000);

			string strJson =
				"{\"MyMessage1\":\"This is message (1)\",\"MyMessage2\":\"This is message (2)\"}";

			// Error!
			//string strJson =
			//	"{'MyMessage1':'This is message (1)','MyMessage2':'This is message (2)'}";

			return (strJson);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn08()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult GetJson04_1()
		{
			//string strLastName = Request.QueryString["lastName"];
			//string strFirstName = Request.QueryString["firstName"];

			string strLastName = Request.Params["lastName"];
			string strFirstName = Request.Params["firstName"];

			System.Threading.Thread.Sleep(5000);

			string strMessage =
				string.Format("Full Name: {0} {1}",
				strFirstName, strLastName).ToString();

			return (Json(new { MyMessage = strMessage },
				System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult GetJson04_2(string firstName, string lastName)
		{
			System.Threading.Thread.Sleep(5000);

			string strMessage =
				string.Format("Full Name: {0} {1}",
				firstName, lastName).ToString();

			return (Json(new { MyMessage = strMessage },
				System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.JsonResult GetJson04_3(Models.Person person)
		{
			System.Threading.Thread.Sleep(5000);

			string strMessage =
				string.Format("Full Name: {0} {1}",
				person.FirstName, person.LastName).ToString();

			return (Json(new { MyMessage = strMessage },
				System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetJson04_4()
		{
			//string strLastName = Request.Form["lastName"];
			//string strFirstName = Request.Form["firstName"];

			string strLastName = Request.Params["lastName"];
			string strFirstName = Request.Params["firstName"];

			System.Threading.Thread.Sleep(5000);

			string strMessage =
				string.Format("Full Name: {0} {1}",
				strFirstName, strLastName).ToString();

			return (Json(new { MyMessage = strMessage },
				System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetJson04_5(string firstName, string lastName)
		{
			System.Threading.Thread.Sleep(5000);

			string strMessage =
				string.Format("Full Name: {0} {1}",
				firstName, lastName).ToString();

			return (Json(new { MyMessage = strMessage },
				System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetJson04_6(Models.Person person)
		{
			System.Threading.Thread.Sleep(5000);

			string strMessage =
				string.Format("Full Name: {0} {1}",
				person.FirstName, person.LastName).ToString();

			var varJsonResult =
				Json(new { MyMessage = strMessage },
				System.Web.Mvc.JsonRequestBehavior.AllowGet);

			// توجه! دستور ذيل مهم می باشد
			varJsonResult.MaxJsonLength = System.Int32.MaxValue;

			return (varJsonResult);
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn09()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn10()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn11()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		//[System.Web.Mvc.OutputCache(Duration = 60)]
		public System.Web.Mvc.PartialViewResult GetCreatePartialView()
		{
			System.Threading.Thread.Sleep(5000);

			return (PartialView("_Partial_CreatePerson"));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Learn20()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult LearnDialog01()
		{
			return (View());
		}
	}
}
