using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AngularJSSite.API.ViewModels.Account
{
	public class AccountLoginInput
	{
		[Required]
		[RegularExpression(@"^[A-Za-z0-9][A-Za-z0-9_.+-]*@[0-9a-zA-Z][0-9a-zA-Z_.-]*\.[a-zA-Z]{2,9}$")]
		public string Email { get; set; }


		public string Password { get; set; }
	}
}