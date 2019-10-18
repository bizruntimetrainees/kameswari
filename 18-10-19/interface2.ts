interface person{
    age:number;
}
interface Musian extends person{
    instrument:string;
}
var drummer=<Musian>{};
drummer.age=27;
drummer.instrument="drummer";
console.log("Age"+drummer.age);
console.log("instument"+drummer.instrument);