(function () {
    angular
        .module('TaskApp')
        .controller('TasksController', TasksController);

    function TasksController() {
        var vm = this;
        vm.addTask = addTask;

        vm.tasks = [
            { name: 'Feed dog' },
            { name: 'Take out trash' },
            { name: 'Water lawn' }
        ];

        function addTask() {
            vm.tasks.push({ name: vm.newTask });
            vm.newTask = '';
        }
    }
})();