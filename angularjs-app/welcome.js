var app = angular.module('welcome', []);

app.controller('welcomeCtrl', ['$scope', function ($scope) {
    $scope.persons = [];

    $scope.addName = function (name) {
        $scope.persons.push(name);
    }

    $scope.delete = function (name) {
        $scope.persons.splice(name, 1);
    };
}]);