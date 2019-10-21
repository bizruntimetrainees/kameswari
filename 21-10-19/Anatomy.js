"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
operators_1.map(function (x) { return x * x; })(rxjs_1.of(1, 2, 3)).subscribe(function (v) { return console.log("value: " + v); });
