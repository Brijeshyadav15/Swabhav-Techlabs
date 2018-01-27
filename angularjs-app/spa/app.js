angular.module('swabhavSPA', ['ngRoute']).config(['$routeProvider', initializeController])

function initializeController($routeProvider) {
    $routeProvider
        .when("/", {
            templateUrl: "partialTemplates/home.html",
            controller: "homeCtrl"
        })
        .when("/home", {
            templateUrl: "partialTemplates/home.html",
            controller: "homeCtrl"
        })
        .when("/career", {
            templateUrl: "partialTemplates/career.html",
            controller: "careerCtrl"
        })
        .when("/about", {
            templateUrl: "partialTemplates/about.html",
            controller: "aboutCtrl"
        })
};