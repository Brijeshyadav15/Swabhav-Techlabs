var app = angular.module('customFilter', []);

app.controller('customFilterCtrl', function ($scope) {

    $scope.customer = {
        name: "Sachin",
    };
});

app.filter('startsWithA', function () {
    return function (name) {
            return /a/i.test(name.substring(0, 1));
    };
});
