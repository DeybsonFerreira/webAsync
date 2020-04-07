

(function () {


    var webApp = angular.module("webApp", ["ngRoute"]);

    webApp.config(function ($routeProvider) {

        $routeProvider
            .when("/", { controller: "homeController", templateUrl: "./views/home/Index.cshtml" })
            .otherwise({ redirectTo: "/" });

    });

}());
var webApp = angular.module('webApp', []);

