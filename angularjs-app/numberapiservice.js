var module = angular.module('NumberAPI', []).factory('NumberAPISvc', function ($rootScope, $log, $timeout, $q, $http) {
    var obj = {};

    obj.getData = function (number) {
        var defer = $q.defer();
        var url = "http://numbersapi.com/" + number;
        $http.get(url)
            .then(function (response) {
                $timeout(function () {
                    defer.resolve(response.data)
                }, 1000)
            },
            function (error) {
                defer.reject("Please enter a Valid Number")
            });
        return defer.promise
    }
    return obj;
});


module.controller("NumberAPICtrl", function ($scope, $rootScope, NumberAPISvc) {
    $scope.findDetails = function () {
        var no = $scope.number;
        NumberAPISvc.getData(no)
            .then(function (response) {
                console.log(response);
                $scope.facts = response;
            },
            function (error) {
                console.log(error);
                $scope.facts = error;
            });
    }
});
