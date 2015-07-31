////FOR EACH WITH ARRAYS
//var team = [
//    "Astros",
//    "Dynamo",
//    "Texans",
//    "Rockets"
//];

//team.forEach(function (team) {
//    console.log(team);
//})


////FILTER AND FOREACH
//var products = new Array();

//products.push({ name: "Cheese", price: 7.00 });
//products.push({ name: "Milk", price: 3.00 });
//products.push({ name: "Wine", price: 97.30 });
//products.push({ name: "Grapes", price: 4.00 });

//var filteredProducts = products.filter(function (product) {
//    return product.price > 5.00;
//});

//filteredProducts.forEach(function (product) {
//    console.log(product);
//});


////REDUCE LAB
//var done = products.reduce(function (previous, current, index, originalArray) {
//    return { price: previous.price + current.price };
//});

//console.log(done.price);


////UNIQUE WORDS LAB
//function CountUnique(arr) {
//    var wordArray = arr.toLowerCase().split(" ");
//    var wordLookup = new Set(wordArray);
//    console.log(wordLookup.size);
//};

//var sentence = "The cat and the cat ate the rat";
//CountUnique(sentence);


////FUNCTIONS ARGUMENT
//function addNumbers() {
//    var result = 0;
//    for (var i = 0; i < arguments.length; i++) {
//        result += arguments[i];
//    }
//    return result;
//}

//var result = addNumbers(1, 2, 3, 4, 5);
//console.log(result);


////UNDERSTANDING "THIS"
//var counter = {
//    _count: 0,
//    addCount: function () {
//        this._count++;
//        console.log(this, this._count);
//    }
//};

//counter.addCount();  //"this" is refering to the instance of counter (value of the object it's on)

////window.setInterval(counter.addCount.bind(counter), 1000);
//counter.addCount(); //writes 1
//counter.addCount(); //writes 2
//counter.addCount(); //writes 3


////REVEALING MODULE PATTERN
//var module = (function () {

//    //private method
//    function _calculatePrice(price) {
//        return price + _calculateTax(price)
//    }

//    //private method
//    function _calculateTax(price) {
//        return price * 0.08;
//    }

//    return {
//        calculatePrice: _calculatePrice
//    };
//})();

//module.calculatePrice(100); //returns 108


////MODULE PATTERN/CLOSURE
//var buttons = document.getElementsByTagName("button");
//addClickHandlers(buttons);

//function addClickHandlers(buttons) {
//    for (var i = 0; i < buttons.length; i++) {
//        addClickHander(buttons[i], i);
//        buttons[i].addEventListener("click", function () {
//            alert("You clicked button " + [i]);
//        });
//    }
//}

//function addClickHander(button, index) {
//    button.addEventListener("click", function () {
//        alert("You clicked button " + index);
//    });
//}


////CLOSURE
//var func = (function getFunction() {
//    var message = "Hello World";

//    return function () {
//        console.log(message + " -- that's what she said.");
//    }
//})();

//func();


////PROTOTYPE CONSTRUCTOR FUNCTION
//function Product(name, price) {
//    this.name = name;
//    this.price = price;
//}

//Product.prototype = {
//    calculateTax: function () {
//        return this.price * 0.08;
//    }
//}

//var product1 = new Product("Milk", 2.33);
//var product2 = new Product("Cheese", 4.33);

//console.log(product1);
//console.log(product2);


//'use strict';

////USING CLASSES LIKE C#
//class Product {
//    constructor(name, price) {
//        this._name=name;
//        this._price = price;
//    }

//    calculateTax() {
//        return this._price * 0.08;
//    }
//};

//var product1 = new Product('Milk', 2.33);
//var product2 = new Product('Cookies', 4.33);

//class Car extends Product {
//    constructor(name, price, model) {
//        super(name, price);
//        this._model = model;
//    }

//    static listModels() {
//        return new Set(["Porsche 911", "Tesla Model S", "BMW M5"]) //Call as Car.listModels();
//    }
//}

//var car1 = new Car("Porsche", 190000.00, "911");


////PRIVATE METHODS AND FIELDS LAB -- WAY 1
//function Product(name, price) {
//    this.name = name;
//    this.price = price;

//    function _calculateTax(price) {
//        return price * 0.08;
//    }

//    this.calculateTotalPrice = function () {
//        return this.price + _calculateTax(this.price);
//    }
//}

//var product1 = new Product("Cookies", 2.99);
//product1.calculateTotalPrice();


////PRIVATE METHODS AND FIELDS LAB -- WAY 2
//function Product(name, price) {
//    this.name = name;
//    this.price = price;
//}

//Product.prototype = (function () {

//    function _calculateTax(price) {
//        return price * 0.08;
//    }

//    function _calculateTotalPrice() {
//        return this.price + _calculateTax(this.price);
//    }

//    return {
//        calculateTotalPrice: _calculateTotalPrice
//    };
//})();

//var product1 = new Product("Cookies", 2.99);
//product1.calculateTotalPrice();


////PRIVATE METHODS AND FIELD LAB -- WAY 3
//function Product(name, price) {
//    this.name = name;
//    this.price = price;
//    var that = this;

//    function _calculateTax() {
//        return that.price * 0.08;
//    }

//    this.calculateTotalPrice = function () {
//        return this.price + _calculateTax();
//    }
//}

//var product1 = new Product("Cookies", 2.99);
//product1.calculateTotalPrice();

function foo(x) {
    var tmp = 3;

    return function (y) {
        alert(x + y + (++tmp)); // will also alert 16
    }
}

var bar = foo(2); // bar is now a closure.
bar(10);