using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSSite.API.ViewModels.Account
{
	public class AccountGetOutput
	{
		public int UserId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}