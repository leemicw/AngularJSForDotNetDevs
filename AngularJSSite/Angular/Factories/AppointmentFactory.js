(function () {
	var AppointmentFactory = function ($http) {

		var factory = {};

		factory.GetAppointments = function (patientId) {
			return $http({
				url: '/api/Appointment/GetAppointments',
				method: 'GET',
				params: { 'patientId': patientId }
			});
		}

		return factory;
	}

	AppointmentFactory.$inject = ['$http'];

	angular.module('PatientPortal').factory('AppointmentFactory', AppointmentFactory);

}());