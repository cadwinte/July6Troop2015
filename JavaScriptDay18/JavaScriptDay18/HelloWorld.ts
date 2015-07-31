﻿'use strict'
class Product {
    private _name
    private _price

    constructor(name, price) {
        this._name = name;
        this._price = price;
    }

    calculateTax() {
        return this._price * 0.08;
    }
};

class Car extends Product {
    private _model;

    constructor(name, price, model) {
        super(name, price);
        this._model = model;
    }
}

var car1 = new Car("Ferrari", 400000.00, "F12");
var car2 = new Car("Tesla", 90000.00, "Model S");


function addNumbers(val1: number, val2: number): number {
    return val1 + val2;
}

addNumbers(5, 10.5);