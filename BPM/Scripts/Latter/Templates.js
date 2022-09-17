var app = angular.module('app', ['ui.bootstrap', 'ServicePetitions', 'ngMessages']);
app.controller('LattersCtrl', ['$scope','Petition',function ($scope, Petition) {
    $scope.Selects = {};
    $scope.model = {};
    $scope.SelectContext = {
        Id_Cause: null,
        Id_Skill: null
    };
    $scope.Items = [];
    $scope.newTemplate = {
        Id_typeLatter: null,
        Id_TypeNotification: null,
        Id_DocumentCloud: null
    };
    $scope.DocumentEdit = null;
    $scope.ListTemplates = [];
    $scope.charges = {
        createDocument: false,
        getModalDocument: false,
        submitTotal: false
    };
    $scope.errorsNotification = {
        items: false,
        files: false,
        submit: false
    };
    $scope.successNotification = {
        submit: false
    };
    $scope.IsUpdate = false;
    $scope.IdDelete = null;

    $scope.initSubmit = function () {
        $scope.errorsNotification = {
            items: false,
            files: false,
            submit: false
        };

        if ($scope.FormTemplate.$valid) {

            if ($scope.model.Id_TypeTemplate === 2) {

                if ($scope.Items.length !== 0) {

                    validateTemplates();
                } else {
                    $scope.errorsNotification.items = true;
                }

            } else {
                validateTemplates();
            }

        }
    };

    function validateTemplates() {
        if ($scope.ListTemplates.length !== 0) {
            submitTotal();
        } else {
            $scope.errorsNotification.files = true;
        }
    }

    function submitTotal() {
        $scope.charges.submitTotal = true;
        var model = {
            url: $scope.IsUpdate ? '/api/LattersApi/UpdateTemplate' : '/api/LattersApi/InsertTemplate',
            data: {
                Id: $scope.model.Id,
                Name: $scope.model.Name,
                Description: $scope.model.Description,
                Id_TypeTemplate: $scope.model.Id_TypeTemplate,
                Id_Company: $scope.model.Id_TypeTemplate === 1 ? $scope.model.Id_Company : null,
                Exceptions: $scope.model.Id_TypeTemplate === 2 ? $scope.Items : null,
                Templates: $scope.ListTemplates
            }
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

    $scope.AddItem = function () {
        $scope.errorsNotification = {
            items: false,
            files: false
        };
        if ($scope.SelectContext.Id_Cause || $scope.SelectContext.Id_Skill || $scope.SelectContext.Id_City || $scope.SelectContext.Id_Company)
            $scope.Items.push($scope.SelectContext);
        $scope.clearAdd();
    };

    $scope.clearAdd = function () {
        $scope.SelectContext = {
            Id_Cause: null,
            Id_Skill: null
        };
    };

    $scope.CreateNewDocument = function () {
        if ($scope.newTemplate.Id_typeLatter && $scope.newTemplate.Id_TypeNotification) {
            $scope.charges.createDocument = true;
            Petition.PetitionServer("/api/LattersApi/CreateNewDocument", true, null).then(function success(response) {
                $scope.newTemplate.Id_DocumentCloud = response;
                $scope.ListTemplates.push($scope.newTemplate);
                $scope.newTemplate = {
                    Id_typeLatter: null,
                    Id_TypeNotification: null,
                    Id_DocumentCloud: null
                };
                $scope.charges.createDocument = false;
            },
                function error(er) {
                    console.error(er);
                    $scope.charges.createDocument = false;
                }
            );
        }
    };

    $scope.GetPremisionFileEdit = function (idFile) {
        $scope.charges.getModalDocument = true;
        viewDocumentInModal(idFile,true);
        setTimeout(function () {
            $scope.charges.getModalDocument = false;
            $scope.$apply();
        }, 4000);
    };

    $scope.ChargueModalDataEdit = function (id) {
        Petition.PetitionServer("/api/LattersApi/SelectTemplate?input=" + id, true, null).then(function success(response) {
            $scope.model = {
                Id: response.Id,
                Name: response.Name,
                Description: response.Description,
                Id_TypeTemplate: response.Id_TypeTemplate,
                Id_Company: response.Id_Company
            };
            $scope.Items = response.Exceptions;
            $scope.ListTemplates = response.Templates;
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
        Petition.PetitionServer("/api/LattersApi/DeleteTemplate?input=" + $scope.IdDelete, true, null).then(function success(response) {
            document.location.reload();
        },
            function error(er) {
                document.location.reload();
                console.error(er);
            }
        );
    };

    function clearModel() {
        $scope.model = {};
        $scope.SelectContext = {
            Id_Cause: null,
            Id_Skill: null
        };
        $scope.Items = [];
        $scope.newTemplate = {
            Id_typeLatter: null,
            Id_TypeNotification: null,
            Id_DocumentCloud: null
        };
        $scope.DocumentEdit = null;
        $scope.ListTemplates = [];
        $scope.charges = {
            createDocument: false,
            getModalDocument: false,
            submitTotal: false
        };
        $scope.errorsNotification = {
            items: false,
            files: false,
            submit: false
        };
        $scope.successNotification = {
            submit: false
        };
    }

    function init() {
        Petition.PetitionServer("/api/LattersApi/GetInitTemplate", true, null).then(function success(response) {
            $scope.Selects = response;
            $scope.IframeContent = response;
        },
            function error(er) {
                console.error(er);
            }
        );
    }
    init();
}]);