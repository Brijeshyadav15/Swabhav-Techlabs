var module = angular.module('swabhav', []).factory('MathService', ['$rootScope', '$log', '$timeout', '$q', function ($rootScope, $log, $timeout, $q) {
    $rootScope.companyName = "Hi-Tech";
    $log.log("Inside Main Service");
    var obj = {};

    obj.cubeEvenNo = function (no) {
        if (no % 2 == 0)
            return no * no * no;
        else
            return "Not Even Number"
    }

    obj.getDataEvenNo = function getData(no) {
        var defer = $q.defer()
        if (no % 2 == 0) {
            $timeout(function () {
                defer.resolve('Number is  a even number')
            }, 2000)
        }
        else {
            defer.reject('Number is not a even number')
        }

        return defer.promise
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

module.controller("SecondCtrl", ['$scope', '$rootScope', 'MathService', function ($scope, $rootScope, MathService) {
    console.log($rootScope.companyName);
    console.log("Inside Second Controller");
    console.log(MathService.cubeEvenNo(50));

    MathService.getDataEvenNo(50)
        .then(function (response) {
            console.log(response);
        },
        function (error) {
            console.log(error);
        });
}]);