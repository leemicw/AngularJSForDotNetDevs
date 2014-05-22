(function () {

	var AppointmentsController = function ($scope, $log, $routeParams, AppointmentFactory) {
		var patientId = $routeParams.patientId;
		$scope.appointmentsLoaded = false;

		function init() {
			AppointmentFactory.GetAppointments(patientId)
				.success(function (appointments) {
					$scope.appointments = appointments;
					$scope.appointmentsLoaded = true;
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