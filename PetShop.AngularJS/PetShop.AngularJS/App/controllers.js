(function () {
    angular
        .module('PetStoreApp')
        .controller('PetStoreController', function () {

        this.pets = [
            {
                name: "Dogs",
                animals: [
                    { name: "Clyde", url: 'http://goo.gl/mIGqgP' },
                    { name: "Dwight", url: 'http://goo.gl/vCqoWh' },
                    { name: "Wesley", url: 'http://goo.gl/rn14PU' }
                ]
            },
            {
                name: "Bunnies",
                animals: [
                    { name: "Larry", url: 'https://goo.gl/9xAkIF' },
                    { name: "Fred", url: 'https://goo.gl/rA1yrw' },
                    { name: "Killer Rabbit", url: 'http://goo.gl/Ciee3A' }
                ]
            },
            {
                name: "Cats",
                animals: [
                    { name: "Grumpy Cat", url: 'https://goo.gl/M3HwJK' },
                    { name: "MeowMeowMcGee", url: 'https://goo.gl/yFX23X' },
                    { name: "Lil Bub", url: 'http://goo.gl/EQTUQV' }
                ]
            }

        ];
    });
})();