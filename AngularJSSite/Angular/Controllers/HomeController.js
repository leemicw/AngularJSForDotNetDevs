(function () {
    'use strict';

    var controllerId = 'HomeController';

    angular.module('PatientPortal').controller(controllerId,
        ['$scope', HomeController]);

    function HomeController($scope) {
        $scope.title = 'HomeController';
        $scope.activate = activate;

        function activate() { }
    }
})();
