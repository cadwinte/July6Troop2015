(function () {
    'use strict';

    angular
        .module('TrailApp')
        .controller('HomeController', ['trailsService', HomeController])
        .controller('LoginController', ['loginService', '$location', LoginController])
        .controller('TrailsController', ['trailsService', TrailsController])
        .controller('HeaderController', ['loginService', '$location', HeaderController])
        .controller('CreateTrailsController', ['createService', CreateTrailsController]);


    //HEAD CONTROLLER
    function HeaderController(loginService, $location) {
        var vm = this;
        vm.isLoggedIn = isLoggedIn;
        vm.logout = logout;

        function isLoggedIn() {
            return loginService.isLoggedIn();
        }

        function logout() {
            loginService.logout();
            $location.path('/');
        }
    }

    //HOME CONTROLLER
    function HomeController(trailsService) {
        var vm = this;

        trailsService.getTrails().then(success, fail);

        function success(data) {
            vm.trails = data;
        }

        function fail() {
            alert('Failed to get your trails');
        }
    }

    //LOGIN CONTROLLER
    function LoginController(loginService, $location) {
        var vm = this;
        vm.login = login;
        vm.isLoading = isLoading;
        vm.loading = false;

        function isLoading() {
            return vm.loading;
        }

        function login() {
            vm.loading = true;
            loginService.login(vm.username, vm.password).then(success, fail);
        }

        function success() {
            vm.loading = false;
            $location.path('/trails');
        }

        function fail() {
            vm.loading = false;
            alert("Login Failed!!!"); 
        }
    }

    //TRAILS CONTROLLER
    function TrailsController(trailsService) {
        var vm = this;
        vm.editTrail = editTrail;
        vm.addEdit = addEdit;
        vm.edit = {};
        vm.removeTrail = removeTrail;

        function removeTrail() {
            trailsService.deleteTrail().then(trabajo, noTrabajo)
        }

        function trabajo() {
            window.location = "/#/";
            console.log(trail);
        }

        function noTrabajo() {
            alert('It did not delete');
        }


        function editTrail() {
            trailsService.edit(vm.edit).then(pass, noPass);

        }

        function pass(data) {
            trailsService.getTrails().then(success, fail);
        }

        function noPass() { }

        function addEdit(trail) {
            vm.edit.id = trail;

            vm.statuses = [
                'Clear',
                'Closed',
                'Flooded',
                'Muddy',
                'Blocked',
                'Damanged'
            ];
            
        }

        trailsService.getTrails().then(success, fail);

        function success(data) {
            vm.trails = data;
            //console.log(data);
        }

        function fail() {
            alert('Failed to get your trails');
        }
    }

    //CREATE TRAILS CONTROLLER
    function CreateTrailsController(createService) {
        var vm = this;
        vm.add = add;
        
        function add() {
            var trail = {
                trailNumber: vm.TrailNumber,
                name: vm.Name,
                status: vm.Status,
                time: vm.Time
            };
            createService.createTrails(trail).then(success, fail);
        }

        vm.statuses = [
            'Clear',
            'Closed',
            'Flooded',
            'Muddy',
            'Blocked',
            'Damanged'
        ];

        function success() {
            window.location = "/#/";            
        }

        function fail() {}
    }
})();