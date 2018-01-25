angular.module('numberAPI', []).controller('numberAPICtrl', function ($scope, $http) {

    $scope.findDetails = function () {
        var number = $scope.number;
        var url = "http://numbersapi.com/" + number;
        $http.get(url)
            .then(function (r) {
                console.log(r);
                $scope.facts = r.data;
            },
            function (r) {
                $scope.facts = "Please Enter valid number";
            });
    }
});
