(function () {
	var PatientFactory = function ($http) {

		var factory = {};

		factory.GetPatients = function () {
			return $http.get('/api/Patient/GetPatients');
		}

		factory.SavePatient = function (patient) {
			return $http({
				url: '/api/Patient/SavePatient',
				method: 'POST',
				data: patient
			});
		}

		factory.ProviderType = 'Factory';

		return factory;
	}

	PatientFactory.$inject = ['$http'];

	angular.module('PatientPortal').factory('PatientFactory', PatientFactory);

}());