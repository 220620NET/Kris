
(function(){
    if(true){
        let foo = 'bar'
        var bar = 'foo'
    }
    //console.log(foo);
    console.log(bar);
})()
//console.log(bar);

function aFunction(a,b,c){
    // do something here
    return a;
}
let clickHandler = function(){
    console.log('you clicked me!');
}
clickHandler = aFunction;
clickHandler = ()=>{
    console.log('arrowfunction handline click event')
}

let objectExample ={
    'key':'value',
    'anotherkey':2,
    'arrayKey':[1,2,3,true],
    'objKey':{}
};
console.log(objectExample.key);
console.log(objectExample['objKey']);