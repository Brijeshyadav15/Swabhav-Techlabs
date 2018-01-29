angular.module('studentSPA').controller('addStudentCtrl', ['$scope', 'studentSVC', function ($scope, studentSVC) {
    $scope.addStudent = function () {
        var isMale = $scope.gender == 'Male' ? 'true' : 'false';

        var student = {
            "age": $scope.student.age,
            "date": $scope.student.date,
            "email": $scope.student.email,
            "name": $scope.student.name,
            "RollNo": $scope.student.rollNo,
            "isMale": isMale,
        }
        studentSVC.addStudent(student);
    }
}]);