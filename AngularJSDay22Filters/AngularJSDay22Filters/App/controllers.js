(function () {
    angular
        .module('MyApp')
        .controller('FoodController', FoodController);

    function FoodController() {
        var vm = this;

        vm.food = [
            'Milk',
            'Marzipan',
            'Mustard',
            'Eggs',
            'Eggs',
            'Tacos',
            'Milk'
        ];
    }
})();