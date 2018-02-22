var message = "Hello World";
console.log(message);
var num = 12;
console.log(num);
var Hello = /** @class */ (function () {
    function Hello() {
    }
    Hello.prototype.greet = function () {
        console.log("Hello World");
    };
    return Hello;
}());
var obj = new Hello();
obj.greet();
var firstname = "Brijesh";
var years = 22;
var months = 10;
var sum = years + months;
console.log("First Name is:" + firstname);
console.log("Age:" + years);
console.log("Age:" + months);
console.log("Sum :" + sum);
