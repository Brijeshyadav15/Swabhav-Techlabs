var module = angular.module('swabhavStudent', []).factory('StudentsCrud', ['$rootScope', '$http', function ($rootScope, $http) {
    var obj = {};
    $rootScope.studentData;
    obj.getData = function (callback) {

        var url = "http://gsmktg.azurewebsites.net/api/v1/techlabs/test/students/";
        $http.get(url)
            .then(function (response) {
                $rootScope.studentData = response;
            },
            function (error) {
                $rootScope.studentData = error;
            });
    }
    return obj;
}]);

module.controller("studentCtrl", ['$rootScope', 'StudentsCrud', '$http', function ($rootScope, StudentsCrud, $http) {
    console.log(StudentsCrud.getData());
    console.log($rootScope.studentData);

}]);
