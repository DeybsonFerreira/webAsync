
//#region ANGULAR
webApp.controller('HomeController', ["$scope", "$http", function ($scope, $http) {

    window.Scope = $scope;
    $scope.PersonList = [];


    $scope.GetPerson = function () {
        $scope.PersonList = [];
        $http.get("/Home/GetPerson").then(function (result) {
            let list = result.data.personResult;
            $scope.PersonList = list;

        }, function (error) {
            console.log(error);
        });
    };

    $scope.GetPersonAsync = function () {
        $scope.PersonList = [];
        $http.get("/Home/GetPersonAsync").then(function (result) {
            let list = result.data.personResult;
            $scope.PersonList = list;

        }, function (error) {
            console.log(error);
        });
    };


}]);
