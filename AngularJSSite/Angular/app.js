(function () {

	var app = angular.module('PatientPortal', ['ngRoute', 'ngAnimate']);

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
			.when('/patientAdd', {
				controller: 'PatientAddController',
				templateUrl: 'Angular/Views/PatientAdd.cshtml'
			})
			.when('/appointments/:patientId', {
				controller: 'AppointmentsController',
				templateUrl: 'Angular/Views/Appointments.cshtml'
			})
			.otherwise({
				templateUrl: 'Angular/Views/Error404.cshtml'
			});
	});

}());