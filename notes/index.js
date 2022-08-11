
// (function(){
//     if(true){
//         let foo = 'bar'
//         var bar = 'foo'
//     }
//     //console.log(foo);
//     console.log(bar);
// })()
// //console.log(bar);

// function aFunction(a,b,c){
//     // do something here
//     return a;
// }
// let clickHandler = function(){
//     console.log('you clicked me!');
// }
// clickHandler = aFunction;
// clickHandler = ()=>{
//     console.log('arrowfunction handline click event')
// }

// let objectExample ={
//     'key':'value',
//     'anotherkey':2,
//     'arrayKey':[1,2,3,true],
//     'objKey':{}
// };
// console.log(objectExample.key);
// console.log(objectExample['objKey']);


//hoisting
//function declaration the whole function defn gets hoisted(aka registered in the lexical environment, which is a phonebook/dictionary of variable/function names the browser engine keeps during run time)
console.log(foo());
function foo(){
    return 'bar';
}
var subjectObject = {
    "Front-end": {
      "HTML": ["Links", "Images", "Tables", "Lists"],
      "CSS": ["Borders", "Margins", "Backgrounds", "Float"],
      "JavaScript": ["Variables", "Operators", "Functions", "Conditions"]
    },
    "Back-end": {
      "PHP": ["Variables", "Strings", "Arrays"],
      "SQL": ["SELECT", "UPDATE", "DELETE"]
    }
  }
  window.onload = function() {
    var subjectSel = document.getElementById("subject");
    var topicSel = document.getElementById("topic");
    var chapterSel = document.getElementById("chapter");
    for (var x in subjectObject) {
      subjectSel.options[subjectSel.options.length] = new Option(x, x);
    }
    subjectSel.onchange = function() {
      //empty Chapters- and Topics- dropdowns
      chapterSel.length = 1;
      topicSel.length = 1;
      //display correct values
      for (var y in subjectObject[this.value]) {
        topicSel.options[topicSel.options.length] = new Option(y, y);
      }
    }
    topicSel.onchange = function() {
      //empty Chapters dropdown
      chapterSel.length = 1;
      //display correct values
      var z = subjectObject[subjectSel.value][this.value];
      for (var i = 0; i < z.length; i++) {
        chapterSel.options[chapterSel.options.length] = new Option(z[i], z[i]);
      }
    }
  }
window.onscroll= function(){
    console.log('scrolling');
}
//with variable declaration, the variable itself gets registered but not the actual value, until it reaches the initialization step
console.log(foo2);
var foo2 = function(){return 'bar'};
console.log(foo2());

//with let and const the runtime knows about the names but it won't let you use it
//console.log(foo3);
let foo3='bar';
console.log(foo3)