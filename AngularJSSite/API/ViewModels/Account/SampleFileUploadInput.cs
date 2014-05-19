using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSSite.API.ViewModels.Account
{
	public class SampleFileUploadInput
	{
		public string SessionKey { get; set; }
		public HttpPostedFileBase File { get; set; }
	}
}