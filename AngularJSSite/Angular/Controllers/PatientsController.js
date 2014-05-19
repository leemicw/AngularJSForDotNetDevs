(function () {

	var PatientsController = function ($scope, $log, PatientFactory) {

        function init() {
        	PatientFactory.GetPatients()
				.success(function (patients) {
					$scope.patients = patients;
				})
				.error(function (data, status) {
					$log.log(data.error + ' ' + status);
				});
        }

        init();

        $scope.DataProviderType = PatientFactory.ProviderType;
    }

	PatientsController.$inject = ['$scope', '$log', 'PatientFactory'];

    angular.module('PatientPortal').controller('PatientsController', PatientsController);
})();
