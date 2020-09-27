namespace Infrastructure
{
	/// <summary>
	/// Version: 1.0.0
	/// Update Date: 1394/04/09
	/// Changed In Version: 1.9.8
	/// Developer: Mr. Dariush Tasdighi
	/// </summary>
	public class JsonData : System.Object
	{
		public enum JsonResultStates : int
		{
			Danger = 0,
			Success = 1,
			Warning = 2,
		}

		public class NotificationClass : System.Object
		{
			public NotificationClass()
			{
				messages =
					new System.Collections.Generic.List<string>();
			}

			public bool display { get; set; }

			public string title { get; set; }

			public string cssClass { get; set; }

			public System.Collections.Generic.IList<string> messages { get; set; }
		}

		public JsonData()
		{
			notification =
				new NotificationClass();
		}

		public object data { get; set; }

		public JsonResultStates state { get; set; }

		public NotificationClass notification { get; set; }

		public System.Web.Mvc.JsonResult GetJsonResult()
		{
			switch (state)
			{
				case JsonResultStates.Danger:
				{
					notification.cssClass = "dtx-danger";

					if (string.IsNullOrWhiteSpace(notification.title))
					{
						notification.title = "خطا";
					}

					break;
				}

				case JsonResultStates.Success:
				{
					notification.cssClass = "dtx-success";

					if (string.IsNullOrWhiteSpace(notification.title))
					{
						notification.title = "توضيح";
					}

					break;
				}

				case JsonResultStates.Warning:
				{
					notification.cssClass = "dtx-warning";

					if (string.IsNullOrWhiteSpace(notification.title))
					{
						notification.title = "اخطار";

					}
					break;
				}
			}

			JsonResult oJsonResult =
				new JsonResult(data: this);

			return (oJsonResult);
		}
	}
}
