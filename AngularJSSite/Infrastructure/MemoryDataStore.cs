using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSSite.Infrastructure
{
	public class MemoryDataStore
	{
		private static List<Patient> _Patients = new List<Patient>();

		public static void InitData(){
			_Patients.Add(new Patient() { PatientId = 1, FirstName = "John", LastName = "Lewis" });
			_Patients.Add(new Patient() { PatientId = 2, FirstName = "Sarah", LastName = "Moore" });
			_Patients.Add(new Patient() { PatientId = 3, FirstName = "Larry", LastName = "Miller" });
			_Patients.Add(new Patient() { PatientId = 4, FirstName = "Amy", LastName = "Clark" });
			_Patients.Add(new Patient() { PatientId = 5, FirstName = "Cindy", LastName = "Brown" });

			DateTime start = DateTime.Now.Date.AddDays(1).AddHours(9);

			_Patients.ElementAt(0).Appointments.Add(new Appointment() { AppointmentId = 1, PatientId = 1, Reason = "Headache", Time = start });
			_Patients.ElementAt(0).Appointments.Add(new Appointment() { AppointmentId = 2, PatientId = 1, Reason = "Headache Follow up", Time = start.AddDays(1) });
			_Patients.ElementAt(0).Appointments.Add(new Appointment() { AppointmentId = 3, PatientId = 1, Reason = "Head Surgery", Time = start.AddDays(2) });
			_Patients.ElementAt(0).Appointments.Add(new Appointment() { AppointmentId = 4, PatientId = 1, Reason = "Head Surgery Follow up", Time = start.AddDays(3) });

			_Patients.ElementAt(1).Appointments.Add(new Appointment() { AppointmentId = 5, PatientId = 2, Reason = "Shoulder Pain", Time = start.AddHours(1) });
			_Patients.ElementAt(2).Appointments.Add(new Appointment() { AppointmentId = 6, PatientId = 3, Reason = "Cold", Time = start.AddHours(2) });
			_Patients.ElementAt(3).Appointments.Add(new Appointment() { AppointmentId = 7, PatientId = 4, Reason = "Fever", Time = start.AddHours(3) });

			_Patients.ElementAt(4).Appointments.Add(new Appointment() { AppointmentId = 8, PatientId = 5, Reason = "Broken Arm", Time = start.AddHours(4) });
			_Patients.ElementAt(4).Appointments.Add(new Appointment() { AppointmentId = 9, PatientId = 5, Reason = "Broken Arm Follow up", Time = start.AddHours(3).AddDays(3) });
		}

		public static IEnumerable<Patient> GetPatients() {
			return _Patients;
		}

		public static Patient SavePatient(Patient PatientToSave) {
			Patient result = null;
			if(PatientToSave.PatientId == 0) {
				int maxPatientId = _Patients.Max(x => x.PatientId);
				_Patients.Add(new Patient() { PatientId = maxPatientId + 1, FirstName = PatientToSave.FirstName, LastName = PatientToSave.LastName });
				result = _Patients.ElementAt(maxPatientId);
			}
			else{
				//do edit here. 
			}
			return result;
		}

		public static IEnumerable<Appointment> GetAppointments(int patientId) {
			foreach(Patient p in _Patients) {
				if(p.PatientId == patientId) {
					return p.Appointments;
				}
			}
			return null;
		}
	}
}