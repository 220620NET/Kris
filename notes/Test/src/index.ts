import pokemon from './interface';

let poke:pokemon={
    id: 1,
    name: 'Pikachu',
    level:5,
    trainerId: 1,
    type: 'electric'
};
(function(){console.log('hello world!');
var foo: string = 'bar';
console.log(foo);
printPokemon(poke);
})();

let pokeTwo:pokemon={
    name:'Pikachu',
    level: 5,
    trainerId: 1,
    type: 'electric'
}

function printPokemon(poke:pokemon):void{
    console.log(poke.name, poke.level,poke.type);
}