(function () {
    'use strict';

    angular
        .module('TrailApp', ['ngRoute', 'angularMoment'])
        .config(['$routeProvider', '$httpProvider', Config])

    function Config($routeProvider, $httpProvider) {
        $routeProvider
            .when('/', {
                templateUrl: '/app/views/home.html',
                controller: 'HomeController',
                controllerAs: 'vm'
            })
            .when('/login', {
                templateUrl: '/app/views/login.html',
                controller: 'LoginController',
                controllerAs: 'vm'
            })
            .when('/trails', {
                templateUrl: '/app/views/trails.html',
                controller: 'TrailsController',
                controllerAs: 'vm'
            })
            .when('/create', {
                templateUrl: '/app/views/create.html',
                controller: 'CreateTrailsController',
                controllerAs: 'vm'
            })
            .when('/register', {
                templateUrl: '/app/views/register.html',
                controller: 'RegisterController',
                controllerAs: 'vm'
            })
            .otherwise({
                redirectTo: '/'
            });

        $httpProvider.interceptors.push('authService');
    };
})();