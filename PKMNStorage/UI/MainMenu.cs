using DataAccess;
using Models;
using Services;
using System.Text.Json;
using CustomExceptions;

namespace UI;

public class MainMenu{
    public void Start(){
        Console.WriteLine("Welcome to PKMN Storage System!");
        Console.WriteLine("Are you already Registed with us?[y/n/exit]");
        
        // first i'm going to get the user's input via readline
        //Then I'll turn it into all lowercase, and i'll take the first letter
        char input = Console.ReadLine().ToLower()[0];
        switch(input){
            case 'n':
                //Register
                Console.WriteLine("Taking you to register.");
                RegisterNewUser();
            break;
            case 'y':
                //Log-in
                Console.WriteLine("Logging you in.");
            break;
            case 'e':
                Console.WriteLine("Goodbye");
                Environment.Exit(0);
            break;
            default:
                //Here, we handle scenarios where the user input matched none of our cases
                Console.WriteLine("I don't understand your input.");
            break;
        }
    }    


//This is my private helper method
//This class doesn't intend on anyone else using this so I keep this 
private void RegisterNewUser(){
    Console.WriteLine("Registering a new user");
    Console.WriteLine("What's your name?");
    string username = Console.ReadLine();
    Console.WriteLine("What is you birthday?");

    //The problem here was that the readline gave a string, but I wanted to store it as DateOnly object. but there was no way to easily go from string to DateOnly
    string DoB= Console.ReadLine();
    DateOnly bDay = DateOnly.FromDateTime(Convert.ToDateTime(DoB));
    Console.WriteLine(username+" "+bDay.ToLongDateString());
    PKMNTrainer registeringTrainer=new PKMNTrainer{
        name=username,
        DoB=bDay
    };
    try{
        PKMNTrainer trainer = new AuthService().Register(registeringTrainer);
        Console.WriteLine("Registered successfully!");
    } catch(JsonException ex){
        Console.WriteLine("Sorry, something happened with our database, please try again");
    }catch(DuplicateRecordException ex){
        Console.WriteLine("Sorry, the name is already taken");
    }
        
}

}