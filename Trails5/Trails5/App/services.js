﻿(function () {
    'use strict';

    angular
        .module('TrailApp')
        .factory('loginService', ['$http', '$q', '$window', loginService])
        .factory('trailsService', ['$http', '$q', '$window', trailsService])
        .factory('authService', ['$window', '$q', authService])
        .factory('createService', ['$http', '$q', '$window', createService])


    //AUTH SERVICE
    function authService($window, $q) {
        var service = {};

        service.request = request;

        function request(config) {
            config.headers = config.headers || {};
            if ($window.sessionStorage.getItem('token')) {
                config.headers.Authorization = 'Bearer ' + $window.sessionStorage.getItem('token');
            }

            return config || $q.when(config);
        }

        return service;
    }

    //LOGINSERVICE
    function loginService($http, $q, $window) {
        var service = {};
        service.login = login;
        service.isLoggedIn = isLoggedIn;
        service.logout = logout;
        service.register = register;

        function register(email, password, confirmPassword) {
            var deferred = $q.defer();
            $http({
                url: '/api/Account/Register',
                method: 'POST',
                data: {
                    'email': email, 'password': password, 'confirmPassword': confirmPassword
                }
            }).success(function (data) {
                deferred.resolve();
            }).error(function (data) {
                deferred.reject(data);
            });

            return deferred.promise;
        }

        function logout() {
            $window.sessionStorage.removeItem('token');
        }

        function isLoggedIn() {
            return $window.sessionStorage.getItem('token');
        }

        function login(username, password) {
            var deferred = $q.defer();

            $http({
                url: '/Token',
                method: 'POST',
                data: 'username=' + username + '&password=' + password + '&grant_type=password',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            }).success(function (data) {
                $window.sessionStorage.setItem('token', data.access_token);
                deferred.resolve();
            }).error(function (data) {
                deferred.reject();
            });

            return deferred.promise;
        }

        return service;
    }


    //TRAILS SERVICE
    function trailsService($http, $q, $window) {
        var service = {};
        service.getTrails = getTrails;
        service.edit = edit;
        service.deleteTrail = deleteTrail;

        function deleteTrail(id) {
            var deferred = $q.defer();

            $http({
                url: '/api/trails/Delete',
                method: 'DELETE',
                data: id
            }).success(function () {
                deferred.resolve(id);
            }).error(function () {
                deferred.reject();
            });

            return deferred.promise;
        }

        function edit(trail) {
            var deferred = $q.defer();

            $http({
                url: '/api/trails/EditTrail',
                method: 'POST',
                data: trail
            }).success(function (data) {
                deferred.resolve(data);
            }).error(function (data) {
                deferred.reject();
            });

            return deferred.promise;
        }

        function getTrails() {
            var deferred = $q.defer();

            $http({
                url: '/api/trails',
                method: 'GET',
            }).success(function (data) {
                deferred.resolve(data);
            }).error(function (data) {
                deferred.reject();
            });

            return deferred.promise;
        }

        return service;
    }


    //CREATE SERVICE
    function createService($http, $q, $window) {
        var service = {};
        var trails = [];
        service.createTrails = createTrails;

        function createTrails(trail) {
            var deferred = $q.defer();

            $http({
                url: '/api/trails/AddTrail',
                method: 'POST',
                data: trail 
            }).success(function () {
                trails.push(trail);
                deferred.resolve();
            }).error(function () {
                deferred.reject();
            })

            return deferred.promise;
        }

        return service;
    }
})();