var printer = function (msg) { return console.log(msg); };
printer("Hello Brijesh");
printer("Hello Akash");
function getData(fn) {
    var no = (Math.random() * 10);
    if (no > 5) {
        fn({ result: "Success " + no });
    }
    else {
        fn({ result: "Error" + no });
    }
}
getData(function (r) { return console.log(r.result); });
getData(function (r) { return console.log(r); });
setTimeout(function () {
    getData(function (r) {
        console.log("into timeout");
        console.log(r);
    });
}, 3000);
