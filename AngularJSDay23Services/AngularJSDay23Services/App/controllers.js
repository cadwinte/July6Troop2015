(function () {

    angular
        .module('ProductApp')
        .controller('ProductsController', ['productService', '$location', ProductsController])
        .controller('CreateProductController', ['productService', CreateProductController]);

    function CreateProductController(productService) {
        var vm = this;

        vm.add = add;
        
        function add() {
            var product = {
                name: vm.name,
                price: vm.price
            };
            productService.createProduct(product).then(success, fail);            
        }

        function success() {

        }

        function fail() {

        }
    }

    function ProductsController(productService, $location) {
        var vm = this;

        productService.getProducts().then(success, fail);

        function success(data) {
            vm.products = data;
        }

        function fail() {

        }
    }
})();