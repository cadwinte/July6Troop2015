(function () {
    angular
        .module('MyApp')
        .controller('ViewAController', ViewAController)
        .controller('ViewBController', ViewBController);

    //$location == dependency injection!!!
    function ViewAController($location) {
        var vm = this;

        vm.message = 'Hello from View A!';
        vm.move = move;

        function move(id) {
            $location.path('viewB/' + id);
        }
    }

    function ViewBController($routeParams) {
        var vm = this;

        vm.message = 'Hello from View B! You requested id ' + $routeParams.id;
    }
})();