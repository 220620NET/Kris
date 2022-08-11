"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
let poke = {
    id: 1,
    name: 'Pikachu',
    level: 5,
    trainerId: 1,
    type: 'electric'
};
(function () {
    console.log('hello world!');
    var foo = 'bar';
    console.log(foo);
    printPokemon(poke);
})();
let pokeTwo = {
    name: 'Pikachu',
    level: 5,
    trainerId: 1,
    type: 'electric'
};
function printPokemon(poke) {
    console.log(poke.name, poke.level, poke.type);
}
