(function () {
    'use strict';

    var controllerId = 'Error404Controller';

    angular.module('PatientPortal').controller(controllerId,
        ['$scope', Error404Controller]);

    function Error404Controller($scope) {
        $scope.title = 'Error404Controller';
        $scope.activate = activate;

        function activate() { }
    }
})();
