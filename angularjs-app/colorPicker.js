var app = angular.module('colorPicker', []);

app.controller('colorPickerCtrl', ['$scope', function ($scope) {

    $scope.color = "Blue";

    $scope.colors = ["Blue", "Red", "Green"];

    $scope.changeColor = function (newColor) {
        return { 'background-color': '' + newColor + '' };

    }
}]);
