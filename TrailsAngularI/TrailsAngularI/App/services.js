(function () {

    angular
        .module('TrailApp')
        .factory('trailService', trailService);

    trailService.$inject = ['$http', 'trailServiceURLs', '$q'];

    function trailService($http, trailServiceURLs, $q) {
        var service = {};
        var trails = [];

        service.getTrails = getTrails;
        service.createTrails = createTrails;

        function getTrails() {
            var deferred = $q.defer();

            $http.get(trailServiceURLs.get).success(function (result) {
                trails.length = 0;

                result.forEach(function (trail) {
                    trails.unshift(trail);
                });
                deferred.resolve(trails);
            }).error(function () {
                deferred.reject();
            });

            return deferred.promise;
        }

        function createTrails(trail) {
            var deferred = $q.defer();

            $http.post(trailServiceURLs.post, trail).success(function () {
                trails.push(trail);
                deferred.resolve();
            }).error(function () {
                deferred.reject();
            });
            
            return deferred.promise;
        }

        return service;
    }

    trailService.$inject = ['$http', 'trailServiceURLs', '$q']
})();