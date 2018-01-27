var module = angular.module('swabhav', []).factory('StudentsCrud', ['$rootScope', '$log', '$timeout', '$q', function ($rootScope, $log, $timeout, $q) {
    var obj = {};

    $obj.getData = function () {
        var number = $scope.number;
        var url = "http://gsmktg.azurewebsites.net/api/v1/techlabs/test/students/";
        $http.get(url)
            .then(function (r) {
                console.log(r);
                $scope.facts = r.data;
            },
            function (r) {
                $scope.facts = "Please Enter valid number";
            });
    }
    return obj;
}]);

module.controller("FirstCtrl", ['$scope', '$rootScope', 'MathService', function ($scope, $rootScope, MathService) {
    console.log($rootScope.companyName);
    console.log("Inside First Controller");
    console.log(MathService.cubeEvenNo(3));

    MathService.getDataEvenNo(50)
        .then(function (response) {
            console.log(response);
        },
        function (error) {
            console.log(error);
        });
}]);
