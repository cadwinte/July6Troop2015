(function () {
    
    angular.module('TrailApp')
        .controller('TrailsController', ['trailService', '$location', TrailsController])
        .controller('CreateTrailController', ['trailService', CreateTrailController]);

    function CreateTrailController(trailService) {
        var vm = this;

        vm.add = add;

        function add() {
            var trail = {
                trailNumber: vm.TrailNumber,
                name: vm.Name,
                status: vm.Status,
                statusUpdate: vm.StatusUpdate
            };
            trailService.createTrails(trail).then(success, fail);
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

        }

        function fail() {

        }
    }

    function TrailsController(trailService, $location) {
        var vm = this;

        trailService.getTrails().then(success, fail);

        function success(data) {
            vm.trails = data;
        }

        function fail() {

        }
    }
})();