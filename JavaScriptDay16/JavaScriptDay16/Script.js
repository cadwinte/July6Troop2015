//var shoppingCart = new Set(["Mushrooms", "Mushrooms", "Tea"]);

//for (var value of shoppingCart) {
//    console.log(value);
//}

//VARIABLES AND DATA TYPES

//var x = prompt("Enter your favorite Number");
//var y = function () {
//    var z = parseFloat(x);

//    if (isNaN(z))
//    { console.log("Invalid Entry"); }
//    else
//    { console.log(z * 100); }
//}
//y();

//var x = prompt("Enter your favorite Number");
//var z = parseFloat(x);

//if (isNaN(z)) {
//    alert("Invalid Entry");
//}
//else {
//    alert(z * 100);
//}




//TRUTHINESS

//function calculateTax(price, taxRate) {
//    if (taxRate === 0) {
//        console.log(price);
//    }
//    else {
//        console.log(price + (price * taxRate || price * 0.08));
//    }
//}



//HANDLING ERRORS

//var addIntergers = function (x, y) {
//    if (isNaN(x) || typeof (x) != "number") {
//        console.error("x is not a number");
//    }
//    else if (isNaN(y) || typeof (y) != "number") {
//        console.error("y is not a number");
//    }
//    else if (x % 1 != 0) {
//        console.error("x is not an integer");
//    }
//    else if (y % 1 != 0) {
//        console.error("y is not an integer");
//    }
//    else {
//        alert(x + y);
//    }
//}

//var customer = {
//    _firstName: " ",
//    _lastName: " ",
//    set firstName(x) {
//        if (!x) {
//            throw new Error("Cannot enter an empty string");
//        }
//        this._firstName = x;
//    },
//    get firstName() {
//        return this._firstName
//    },
//    set lastName(y) {
//        if (!y) {
//            throw new Error("Last name cannot be an empty string");
//        }
//        this._lastName = y;
//    },
//    get lastName() {
//        return this._lastName
//    }
//};


//var dumpAll = function (objects) {
//    var result = "";
//    for (var key in objects) {
//        result += " " + key + " " + " " + objects[key] + " ";
//    }
//    alert(result);
//}


//var customer = {
//    required_firstName: '',
//    required_lastName: '',
//    favoriteColor: ''
//};

//function addRequiredValidtion(obj) {
//    var newObj = {};
//    for (var index in obj) {
//        if (index.indexOf("required_") != -1) {
//            (function (index) {
//                var fieldName = "_" + index.substring(9);
//                newObj[fieldName] = "";
//                Object.defineProperty(newObj, index.substring(9), {
//                    get: function () {
//                        return this[fieldName];
//                    },
//                    set: function (value) {
//                        if (!value)
//                            throw new Error(fieldName.subtring(1) + " is required.");
//                        this[fieldName] = value;
//                    }
//                })
//            })(index);
//        }
//    }

//    return newObj;
//}


//ARRAYS

//var cart = [
//  { name: 'Milk', price: 23.44 },
//  { name: 'Cheese', price: 3.50 },
//  { name: 'Peanuts', price: 8.00 },
//  { name: 'Wine', price: 7.50 }
//];

//var totalPrice = cart.map(function (x) {
//    return x.price;
//});

//var total = totalPrice.reduce(function (y, z) {
//    return y + z;
//});

//console.log(total);

//var total = cart
//    .map(function (b) { return b.price; })
//    .reduce(function (p, c) { return p + c; });

//console.log(total);



//UNIQUE WORDS

//var countWords = function (x) {
//    var count = 0;
//    words = x.split(" ");
//    for (i = 0 ; i < words.length ; i++) {
//        if (words[i] != "")
//            count += 1;
//    }
//    console.log(count);
//}



var lister = function(x) {
    var cart = new Set([x])
    var y = cart.entries();
    var z = y.length;
        console.log(z);
}

lister("The cat and the cat ate the rat");