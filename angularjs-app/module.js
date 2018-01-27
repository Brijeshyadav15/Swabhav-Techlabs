angular.module('swabhav.Customer', ['hitech.invoice']).controller('customerCtrl', ['$rootScope', function ($rootScope) {
    console.log("Inside Customer Controller");
    console.log($rootScope);
    $rootScope.customer = {
        id: 101,
        name: "Brijesh"
    }
}])

angular.module('hitech.invoice', []).controller('invoiceCtrl',['$scope', '$rootScope' ,function ($scope, $rootScope) {
    console.log("Inside Hitech Controller");
    $scope.invoice = {
        id: 102,
        name: "Book1",
        cost: 150
    }
}]);