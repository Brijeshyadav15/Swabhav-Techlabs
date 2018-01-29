var module = angular.module('swabhavStudent', []).factory('StudentsCrud', ['$rootScope', '$http', '$q', function ($rootScope, $http, $q) {
    var obj = {};
    $rootScope.studentData;
    obj.getData = function () {
        var url = "http://gsmktg.azurewebsites.net/api/v1/techlabs/test/students/";
        var defer = $q.defer();
        $http.get(url)
            .then(function (response) {
                $rootScope.studentData = response;
                defer.resolve(response.data);
            },
            function (error) {
                $rootScope.studentData = error;
                defer.reject(error.data);
            });
        return defer.promise
    }

    obj.deleteStudent = function (number) {
        var url = "http://gsmktg.azurewebsites.net/api/v1/techlabs/test/students/" + number;
        $http.delete(url)
            .then(function (response) {
                console.log("Data Deleted");
            },
            function (error) {
                console.log("Data Deleted");
            });
    }

    obj.editStudent = function (student) {

        $rootScope.id = student.rollNo;
        $rootScope.name = student.name;
        $rootScope.email = student.email;
        $rootScope.joining = student.date;
        $rootScope.age = student.age;

        if (student.isMale = "true")
            $rootScope.male = "Male";
        else
            $rootScope.female = "Female";
    }

    obj.addStudent = function (student) {

        var url = "http://gsmktg.azurewebsites.net/api/v1/techlabs/test/students/";
        $http.post(url, student)
            .then(function (response) {
                console.log(response);
            },
            function (error) {
                console.log(response);
            });
    }

    return obj;
}]);

module.controller("studentCtrl", ['$scope', 'StudentsCrud', '$http', function ($scope, StudentsCrud, $http) {

    StudentsCrud.getData()
        .then(function (response) {
            $scope.studentsData = response;
        },
        function (error) {
            console.log("Data not found");
        });

    $scope.deleteStudent = function (rollNo) {
        StudentsCrud.deleteStudent(rollNo);
    }

    $scope.editStudent = function (student) {
        StudentsCrud.editStudent(student);
    }

    $scope.addStudent = function () {
        var age = $scope.age;
        var joining = $scope.joining;
        var email = $scope.email;
        var name = $scope.name;
        var RollNo = $scope.id;
        var gender = $scope.male != null ? 'true' : 'false';

        var student =
            {
                "age": age,
                "date": joining,
                "email": email,
                "name": name,
                "RollNo": RollNo,
                "isMale": gender
            };
        console.log(student);
        StudentsCrud.addStudent(student);
    }
}]);
