using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularJSSite.Infrastructure;

namespace AngularJSSite.API.Controllers
{
	[RoutePrefix("api/Appointment")]
    public class AppointmentController : ApiController
    {
		[Route("GetAppointments")]
		public IEnumerable<Appointment> GetAppointments(int patientId) {
			return MemoryDataStore.GetAppointments(patientId);
		}
    }
}
