(function () {
    angular
        .module('MyApp')
        .controller('FavoriteColorController', FavoriteColorController);

    //this function is a constructor
    function FavoriteColorController() {
        var vm = this;
        vm.color = 'no se';

        //private, not available in the view 
        function changeColor(color) {
            vm.color = color;
        }

        vm.pickColor = function (color) {
            changeColor(color);
        };
    }
})();

(function () {
    angular
        .module('MyApp')
        .controller('NumberOperator', NumberOperator);

    function NumberOperator() {
        var vm = this;
        vm.operator = '+';
        vm.firstNumber = 0;
        vm.secondNumber = 0;
        vm.result = 0;

        function changeOperator(operator) {
            vm.operator = operator;
        }

        vm.pickOperator = function (operator) {
            changeOperator(operator);
            vm.workingOperator(operator);
        };

        vm.workingOperator = function (z) {
            vm.operator = z;

            if (z == '+') {
                return vm.result = vm.firstNumber + vm.secondNumber;
            }
            if (z == '-') {
                return vm.result = vm.firstNumber - vm.secondNumber;
            }
            if (z == '*') {
                return vm.result = vm.firstNumber * vm.secondNumber;
            }
            if (z == '/') {
                return vm.result = vm.firstNumber / vm.secondNumber;
            }
            if (z == '%') {
                return vm.result = vm.firstNumber % vm.secondNumber;
            }
            if (z == '^') {

                return vm.result = Math.pow(vm.firstNumber, vm.secondNumber);
            }
            if (z == '#') {
                for (var i = 1; i < 1001; i++) {
                    if (i % vm.firstNumber == 0 && i % vm.secondNumber == 0) {
                        return vm.result = i;
                    }
                }
            }
            if (z == '√') {
                return vm.result = Math.sqrt(vm.firstNumber + vm.secondNumber);
            }
        }
    }
})();