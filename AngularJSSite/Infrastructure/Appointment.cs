using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSSite.Infrastructure
{
	public class Appointment
	{
		public int AppointmentId { get; set; }
		public int PatientId { get; set; }
		public DateTime Time { get; set; }
		public string Reason { get; set; }
	}
}