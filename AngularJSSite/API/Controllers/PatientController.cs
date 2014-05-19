using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using AngularJSSite.Infrastructure;

namespace AngularJSSite.API.Controllers
{
	[RoutePrefix("api/Patient")]
    public class PatientController : ApiController
    {
		[Route("GetPatients")]
		public IEnumerable<Patient> GetPatients() {
			return MemoryDataStore.GetPatients();
		}
    }
}
