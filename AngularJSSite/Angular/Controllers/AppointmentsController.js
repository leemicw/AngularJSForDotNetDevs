(function () {

	var AppointmentsController = function ($scope, $log, $routeParams, AppointmentFactory) {
		var patientId = $routeParams.patientId;

		function init() {
			AppointmentFactory.GetAppointments(patientId)
				.success(function (appointments) {
					$scope.appointments = appointments;
				})
				.error(function (data, status, headers, config) {
					$log.log(data.error + ' ' + status);
				});
		}

		init();
	};

	AppointmentsController.$inject = ['$scope', '$log', '$routeParams', 'AppointmentFactory'];

	angular.module('PatientPortal').controller('AppointmentsController', AppointmentsController);

}());