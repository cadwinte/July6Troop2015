(function () {

    angular
        .module('MovieApp')
        .factory('movieService', movieService);

    movieService.$inject = ['$http', 'movieServiceURLs', '$q'];

    function movieService($http, movieServiceURLs, $q) {
        var service = {};
        var movies = [];

        service.getMovies = getMovies;

        function getMovies() {
            var deferred = $q.defer();

            $http.get(movieServiceURLs.get).success(function (result) {
                movies.length = 0;

                result.forEach(function (movie) {
                    movies.push(movie);
                });
                deferred.resolve(movies);
            }).error(function () {
                deferred.reject();
            });

            return deferred.promise;
        }

        return service;
    }

    movieService.$inject = ['$http', 'movieServiceURLs', '$q']
})();