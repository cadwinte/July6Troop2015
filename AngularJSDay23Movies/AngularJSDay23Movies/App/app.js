(function () {
    'use strict';

    angular
        .module('MovieApp', [])
        .constant('movieServiceURLs', { get: '/api/movies/', post: '/api/movies/' });
})();