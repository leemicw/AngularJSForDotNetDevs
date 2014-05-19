(function () {

	var app = angular.module('PatientPortal', ['ngRoute']);

	app.config(function ($routeProvider) {
		$routeProvider
			.when('/', {
				controller: 'HomeController',
				templateUrl: 'Angular/Views/Home.cshtml'
			})
			.when('/patients', {
				controller: 'PatientsController',
				templateUrl: 'Angular/Views/Patients.cshtml'
			})
			.when('/appointments/:patientId', {
				controller: 'AppointmentsController',
				templateUrl: 'Angular/Views/Appointments.cshtml'
			})
			.otherwise({
				controller: 'Error404Controller',
				templateUrl: 'Angular/Views/Error404.cshtml'
			});
	});

}());