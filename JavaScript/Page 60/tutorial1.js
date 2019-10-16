var lang = "JavaScript";

function myFunction(lang) {
    this.lang = lang;
    console.log("Hello, welcome to "+this.lang);
};
var Test = new myFunction(lang)

//[statement] ? [code when true] : [code when false]

function myFunction() {
    var status;
    var age = 19;
    status = age > 18 ? "adult" : "minor";
    console.log(status);
}
myFunction()