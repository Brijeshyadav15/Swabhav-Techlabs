angular.module('BindData', []).controller('BindDataCtrl',['$scope', '$timeout', function ($scope, $timeout) {

    $scope.data = {
        developer: "Akash",
        company: "Hi-Tech",
    };

    $scope.customer = {
        name: "Sachin",
        age: 30,
    };

    $timeout(function () {
        $scope.data.developer = "Brijesh";
    }, 1000);
}]);
