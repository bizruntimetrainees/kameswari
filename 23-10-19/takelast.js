"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
var many = rxjs_1.range(1, 100);
var lastThree = many.pipe(operators_1.takeLast(3));
lastThree.subscribe(function (x) { return console.log(x); });
