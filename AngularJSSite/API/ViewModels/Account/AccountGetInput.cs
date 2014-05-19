using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSSite.API.ViewModels.Account
{
	public class AccountGetInput
	{
		public string SessionKey { get; set; }
		public int UserId { get; set; }
	}
}