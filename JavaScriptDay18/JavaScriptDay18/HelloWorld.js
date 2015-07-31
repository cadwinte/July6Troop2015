'use strict';
var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Product = (function () {
    function Product(name, price) {
        this._name = name;
        this._price = price;
    }
    Product.prototype.calculateTax = function () {
        return this._price * 0.08;
    };
    return Product;
})();
;

var Car = (function (_super) {
    __extends(Car, _super);
    function Car(name, price, model) {
        _super.call(this, name, price);
        this._model = model;
    }
    return Car;
})(Product);

var car1 = new Car("Ferrari", 400000.00, "F12");
var car2 = new Car("Tesla", 90000.00, "Model S");

function addNumbers(val1, val2) {
    return val1 + val2;
}

addNumbers(5, 10.5);
