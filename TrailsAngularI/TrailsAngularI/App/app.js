(function () {
    'use strict';

    angular
        .module('TrailApp', [])
        .constant('trailServiceURLs', { get: '/api/trails/', post: '/api/trails/' });
})();