var PQRContext = document.getElementById('ContextPQR').value;
var app = angular.module('app', ['ServicePetitions', 'ngMaterial', 'ngMessages']);

app.controller('LattersCtrl', ['$scope','Petition',function ($scope, Petition) {
}]);
app.controller('HistoricalCtrl', ['$scope', 'Petition', function ($scope, Petition) {
}]);
app.controller('GeneralCtrl', ['$scope', 'Petition', function ($scope, Petition) {

    $scope.Selects = {};
    $scope.model = {};
    $scope.charges = {
        submitTotal: false
    };

    $scope.submitForm = function () {
        $scope.charges.submitTotal = false;
        if ($scope.FormGeneralPQR.$valid) {
            $scope.charges.submitTotal = true;
            console.log($scope.model)
            Petition.PetitionServer("/api/pqr/UpdatePQR", false, $scope.model).then(function success(res) {
                $scope.Update = false;
                $scope.charges.submitTotal = false;
                $scope.init();
            },
                function error(er) {
                    console.error(er);
                    $scope.charges.submitTotal = false;
                }
            );
        }
    };

    $scope.init = function () {
        Petition.PetitionServer('/api/pqr/getPQR?idContext=' + PQRContext, true, null)
            .then(function success(response) {
                $scope.model = response;
            },
                function error(er) {
                    console.error(er);
                }
            );
        Petition.PetitionServer('/api/pqr/GetFieldsInitialPQR', true, null)
            .then(function success(response) {
                $scope.Selects = response;
            },
                function error(er) {
                    console.error(er);
                }
            );
    };

}]);