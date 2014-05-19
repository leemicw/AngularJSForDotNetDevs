using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSSite.Infrastructure
{
	public class Patient
	{
		public int PatientId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public List<Appointment> Appointments { get; set; }

		public Patient() {
			Appointments = new List<Appointment>();
		}
	}
}