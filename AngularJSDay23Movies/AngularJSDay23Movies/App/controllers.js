(function () {

    angular
        .module('MovieApp')
        .controller('MoviesController', ['movieService', '$location', MoviesController]);

    function MoviesController(movieService, $location) {
        var vm = this;

        movieService.getMovies().then(success, fail);

        function success(data) {
            vm.movies = data;
        }

        function fail() {

        }
    }
})();