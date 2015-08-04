(function () {
    angular
        .module('CarApp')
        .controller('CarController', CarController);

    function CarController() {
        var vm = this;

        vm.add = function () {
            vm.message = 'You entered Model: ' + vm.model + ', Price: ' + vm.price;
        }
    }
})();