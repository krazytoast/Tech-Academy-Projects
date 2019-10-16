class Person {
    constructor(firstName, lastName){
        this.firstName = firstName;
        this.lastName = lastName;
    }
    getName(){
        return this.firstName +" "+ this.lastName;
    }
}

var me = new Person('Trisha', 'Saldanha');
var me2 = new Person('Zachery', 'Berkey');

console.log(me.getName());
console.log(me2.getName());