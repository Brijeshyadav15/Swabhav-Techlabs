var app = angular.module('binding', []);

app.controller('bindingCtrl', ['$scope', function ($scope) {
    $scope.text;

    $scope.colors = ["Blue", "Red", "Green"];

    $scope.fontsizes = ["10px", "15px", "25px", "20px"];

    $scope.changeCSS = function () {
        return { 'background-color': '' + $scope.backgroundColor + '', 'color': '' + $scope.fontColor + '', 'font-size': '' + $scope.fontSize + '' };

    }
}]);