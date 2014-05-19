(function () {
	var PatientFactory = function ($http) {

		var factory = {};

		factory.GetPatients = function () {
			return $http.get('/api/Patient/GetPatients');
		}

		factory.ProviderType = 'Factory';

		return factory;
	}

	PatientFactory.$inject = ['$http'];

	angular.module('PatientPortal').factory('PatientFactory', PatientFactory);

}());