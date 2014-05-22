(function () {

	var PatientAddController = function ($scope, $log, PatientFactory) {

		$scope.SavePatient = function() {
			var patientToSave = {
				PatientId: 0,
				FirstName: $scope.firstName,
				LastName: $scope.lastName
			}

			PatientFactory.SavePatient(patientToSave)
				.success(function (patient) {
					$scope.ResultMessage = "New Patient Id is " + patient.PatientId;
				})
				.error(function (data, status) {
					$log.log(data.error + ' ' + status);
				});
		}

	}

	PatientAddController.$inject = ['$scope', '$log', 'PatientFactory'];

	angular.module('PatientPortal').controller('PatientAddController', PatientAddController);
})();
