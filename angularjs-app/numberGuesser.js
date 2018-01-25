var module = angular.module('numberGuesser', []);

module.controller("numberGuesserCtrl", function ($scope) {
    $scope.random = Math.round((Math.random() * 10) * 10);
    console.log($scope.random);

    $scope.checkResult = function (number) {

        if (number == $scope.random) {
            alert("Correct Number");
            console.log("Correct Number");
        }
        else if (number > $scope.random) {
            alert("Greater Number");
            console.log("Greater Number");
        }
        else if (number < $scope.random) {
            alert("Smaller Number");
            console.log("Smaller Number");
        }

    }
});

module.filter('range', function () {
    return function (input, total) {
        total = parseInt(total);

        for (var i = 1; i <= total; i++) {
            input.push(i);
        }

        return input;
    };
});