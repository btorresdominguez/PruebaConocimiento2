var app = angular.module('app', ['ui.bootstrap', 'ServicePetitions', 'ngMessages']);
app.controller('ParagrahpsCtrl', function ($scope, Petition) {
    $scope.Selects = {};
    $scope.model = {};
    $scope.charges = {
        submitTotal: false
    };
    $scope.errorsNotification = {
        submit: false
    };
    $scope.successNotification = {
        submit: false
    };
    $scope.IsUpdate = false;
    $scope.IdDelete = null;

    $scope.initSubmit = function () {
        /*Init variables Validations*/
        $scope.errorsNotification = {
            items: false,
            files: false,
            submit: false
        };
        /*End variables validations*/
        if ($scope.FormTemplate.$valid) {
           
            submitTotal();
        }
    };

   

    function submitTotal() {
        $scope.charges.submitTotal = true;
        var model = {
            url: $scope.IsUpdate ? '/api/LattersApi/UpdateParagraph' : '/api/LattersApi/InsertParagraph',
            data: $scope.model
        };
        Petition.PetitionServer(model.url, false, model.data).then(function success(res) {
            setTimeout(function () {
                $scope.charges.submitTotal = false;
                clearModel();
                document.location.reload();
                $scope.$apply();
            }, 2500);
            $scope.successNotification.submit = true;

        },
            function error(er) {
                console.error(er);
                $scope.errorsNotification.submit = true;
                $scope.charges.submitTotal = false;
            }
        );
    }

    $scope.ChargueModalDataEdit = function (id) {
        Petition.PetitionServer("/api/LattersApi/GetParagraph?input=" + id, true, null).then(function success(response) {
            $scope.model = response[0];
            document.getElementById("BtnUpdateClient").click();
        },
            function error(er) {
                console.error(er);
            }
        );
    };

    $scope.addClient = function () {
        if ($scope.IsUpdate) {
            clearModel();
            $scope.IsUpdate = false;
        }
    };
    $scope.UpdateClient = function () {
        $scope.IsUpdate = true;
    };
    $scope.ConfirmDelete = function () {
        Petition.PetitionServer("/api/LattersApi/DeleteParagraph?input=" + $scope.IdDelete, true, null).then(function success(response) {
            document.location.reload();
        },
            function error(er) {
                document.location.reload();
                console.error(er);
            }
        );
    };

    function clearModel() {
        $scope.Selects = {};
        $scope.model = {};
        $scope.charges = {
            submitTotal: false
        };
        $scope.errorsNotification = {
            submit: false
        };
        $scope.successNotification = {
            submit: false
        };
        $scope.IsUpdate = false;
        $scope.IdDelete = null;
    }

    function init() {
        Petition.PetitionServer("/api/LattersApi/GetParagraphInit", true, null).then(function success(response) {
            $scope.Selects = response;
            console.log(response);
        },
            function error(er) {
                console.error(er);
            }
        );
    }
    init();
});