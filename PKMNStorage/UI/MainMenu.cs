using DataAccess;
using Models;
using Services;

namespace UI;

public class MainMenu{
    public void Start(){
        do{
            Console.WriteLine("Welcome to PKMN Storage System!");
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("[1] Login");
            Console.WriteLine("[2] Register");
            Console.WriteLine("[x] Exit");

            string input = Console.ReadLine();
            switch(input){
                case "1":
                    //log in
                break;
                case "2":
                    //register
                    Console.WriteLine("Registering a new trainer");
                    Console.WriteLine("What is Your Name?");
                    string name = Console.ReadLine();
                    PKMNTrainer newTrainer = new PKMNTrainer();
                    newTrainer.SetName(name);

                    Console.WriteLine("How many badges to you have?");
                    string numBadges = Console.ReadLine();
                    int intBadges = Int32.Parse(numBadges);
                    newTrainer.NumBadges = intBadges;

                    new PKMNService().Register(newTrainer);
                    for(int i = 0; i < PKMNStorage.TrainerRegistry.Length; i++)
                    {
                        if(PKMNStorage.TrainerRegistry[i] != null)
                        {
                            Console.WriteLine(PKMNStorage.TrainerRegistry[i].GetName());
                        }
                    }
                break;
                case "x":
                    Console.WriteLine("goodbye, see you again soon!");
                    System.Environment.Exit(0);
                break;
                default:
                    //Here, we handle scenarios where the user input matched none of our cases
                    Console.WriteLine("I don't understand your input");
                break;
            }
        } while(true);
    }    
}