(function () {
    angular
        .module('EmployeeApp')
        .controller('EmployeeController', EmployeeController);

    function EmployeeController() {
        var vm = this;
        vm.add = add;
        vm.isFullTime = isFullTime;


        vm.types = [
            'FullTime',
            'PartTime'
        ];

        function isFullTime() {
            return vm.selectedType === 'FullTime';
        }

        function add() {
            vm.message = 'Did you finish those TPS reports? ';
        };
    }
})();