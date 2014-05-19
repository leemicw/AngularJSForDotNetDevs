(function () {
	var PatientService = function ($http) {

		this.GetPatients = function () {
			return $http.get('/api/Patient/GetPatients');
		};

		this.ProviderType = 'Service';

	};

	PatientService.$inject = ['$http'];

	angular.module('PatientPortal').service('PatientService', PatientService);

}());