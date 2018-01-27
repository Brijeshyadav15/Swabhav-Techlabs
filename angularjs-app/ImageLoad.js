angular.module('imageLoad', []).controller('imageLoadCtrl', ['$scope', function ($scope) {

    $scope.resume = function () {
        console.log("Inside Function");
        $scope.name = "Brijesh";
        $scope.age = "22";
        $scope.location = "Mumbai";
        $scope.image = "abcd.jpg";
    }

    $scope.resumes = function () {
        $scope.resumes = [{
            name: "Brijesh",
            age: "22",
            location: "Mumbai",
            image: "abcd.jpg"
        },
        {
            name: "Akash",
            age: "21",
            location: "Mumbai",
            image: "abc.jpg"
        }]
    }
}]);
