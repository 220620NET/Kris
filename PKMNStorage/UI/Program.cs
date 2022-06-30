using UI;
// using Models;
// using CustomExceptions;
// using System;

// Console.WriteLine("Main method or test case?");
// string please = Console.ReadLine();
// if(please=="Main"){
//     MainMenu menu=new MainMenu();
//     menu.Start();
// }else{
//     Console.WriteLine("Welcome to Pokemon Storage System!");
//     Console.WriteLine("One convenient place for all your pokemon storage needs!");

//     PKMN testPKMN = new PKMN();
//     try
//     {
//         testPKMN.Level = Int32.Parse(Console.ReadLine());
//         // testPokemon.Level = -1;
//     }
//     catch(InputInvalidException ex)
//     {
//         Console.WriteLine("Exception was thrown");
//         Console.WriteLine(ex.Message);
//     }

//     Console.WriteLine(testPKMN);
// }
new MainMenu().Start();