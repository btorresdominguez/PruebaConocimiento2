angular.module("ServicePetitions", [])
    .factory("Petition", ["$http", "$q", function ($http, $q) {
        var service = {};

        service.PetitionServer = function (url, hasGet, model) {
            var defered = $q.defer();

            var baseUrl = window.location.origin;
            var prefix = window.location.pathname.split('/');

            if (prefix[1] === 'BPM2')
                baseUrl += '/BPM2';

            var urlFinal = baseUrl + url;
            if (hasGet === '') {
                url = (url.substr(0, 1) == '/' ? url : '/' + url);
                urlFinal = baseUrl + url;
                var req = {
                    url: urlFinal,
                    method: 'POST',
                    data: model
                }
                $http(req).then(function successCallback(response) {
                    defered.resolve(response.data);
                },
                    function errorCallback(r) {
                        defered.reject(r);
                    });
                return defered.promise;

            }
            url = (url.substr(0, 1) == '/' ? url : '/' + url);
            if (hasGet == false) {
                hasGet = false;
                urlFinal = baseUrl + url;
            }
            if (hasGet == null && model == null) {
                hasGet = true;
                urlFinal = url;
            }

            if (hasGet) {
                $http.get(urlFinal).then(function successCallback(response) { defered.resolve(response.data); },
                    function errorCallback(response) {
                        defered.reject(response);
                    });
            } else {
                if (hasGet == null) {
                    var req = {
                        url: urlFinal,
                        method: 'POST',
                        data: model,
                        headers: {
                            'Content-Type': undefined
                        },
                        transformRequest: window.angular.identity
                    }
                    $http(req).then(function successCallback(response) {
                        defered.resolve(response.data);
                    },
                        function errorCallback(response) {
                            defered.reject(response);

                        });
                } else {
                    var req = {
                        url: urlFinal,
                        method: 'POST',
                        data: model
                    }

                    $http(req).then(function successCallback(response) {
                        defered.resolve(response.data);
                    },
                        function errorCallback(response) {

                            defered.reject(response);

                        });
                }
            }
            return defered.promise;
        }
        return service;
    }]);
