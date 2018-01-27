angular.module('numberGuesser', []).controller("numberGuesserCtrl", ['$scope', function ($scope) {
    $scope.random = Math.round((Math.random() * 10) * 10);
    $scope.trialCounter = 0;

    $scope.checkResult = function (number) {
        var el = angular.element(event.currentTarget);
        el.removeClass('blankbox').attr('disabled', 'disabled');
        if ($scope.trialCounter < 3) {
            $scope.trialCounter++;
            if (number == $scope.random) {
                console.log("Correct Number");
                el.addClass("bluebox");
            }
            else if (number > $scope.random) {
                console.log("Greater Number");
                el.addClass("redbox");
            }
            else if (number < $scope.random) {
                console.log("Smaller Number");
                el.addClass("greenbox");
            }
        }
        else {
            alert("Sorry You are out of  trails!! You Lost");
            location.reload();
        }

    }
}])
    .filter('range', function () {
        return function (input, total) {
            total = parseInt(total);

            for (var i = 1; i <= total; i++) {
                input.push(i);
            }

            return input;
        };
    });