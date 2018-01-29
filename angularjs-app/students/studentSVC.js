angular.module('studentSPA').factory('studentSVC', ['$rootScope', '$http', '$q', function ($rootScope, $http, $q) {
    var obj = {};
    $rootScope.studentData;

    obj.getData = function () {
        var url = "http://gsmktg.azurewebsites.net/api/v1/techlabs/test/students/";
        var defer = $q.defer();
        $http.get(url)
            .then(function (response) {
                $rootScope.studentData = response.data;
                defer.resolve(response.data);
            },
            function (error) {
                $rootScope.studentData = error;
                defer.reject(error.data);
            });
        return defer.promise
    }

    obj.getByID = function (id) {
        var url = "http://gsmktg.azurewebsites.net/api/v1/techlabs/test/students/" + id;
        var defer = $q.defer();
        $http.get(url)
            .then(function (response) {
                defer.resolve(response.data);
            },
            function (error) {
                $rootScope.studentData = error;
                defer.reject(error.data);
            });
        return defer.promise
    }

    obj.deleteStudent = function (rollNo) {
        var url = "http://gsmktg.azurewebsites.net/api/v1/techlabs/test/students/" + rollNo;
        $http.delete(url)
            .then(function (response) {
                window.location.href = '#/';
            },
            function (error) {
                console.log("Data Deleted");
            });
    }

    obj.addStudent = function (student) {

        var url = "http://gsmktg.azurewebsites.net/api/v1/techlabs/test/students/";
        $http.post(url, student)
            .then(function (response) {
                window.location.href = '#/';
            },
            function (error) {
                console.log(response);
            });
    }

    obj.update = function (id, student) {
        var url = "http://gsmktg.azurewebsites.net/api/v1/techlabs/test/students/" + id;
        $http.put(url, student)
            .success(function (data, status, headers) {
                window.location.href = '#/';
            }).error(function (data, status, header, config) {
                console.log("Data Update Failed");
            });
    }
    return obj;
}]);
