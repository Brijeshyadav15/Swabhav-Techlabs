var message:string = "Hello World" 
console.log(message);

var num:number =12;
console.log(num);   

class Hello{
    greet():void{
        console.log("Hello World");
    }
}

var obj = new Hello();
obj.greet();

var firstname:string ="Brijesh";
var years:number =22;
var months: number = 10;
var sum = years+ months;

console.log("First Name is:"+firstname);
console.log("Age:"+years);
console.log("Age:"+months);
console.log("Sum :"+sum);

var sumString:string = <string> <number> years; 