// Namespace is analogous to packages in java, and it is a logical collection of types, such as classes, enums, and structs
namespace Models;

//Class is a blueprint to create objects
//public is an example of access modifier
//public means that everyone has access to whatever its decorating
public class PokeTrainer
{
    //Empty Constructor
    public PokeTrainer(){
        NumBadges = 0;
        Money = 0;
    }

    //This is constructor overloading
    public PokeTrainer(string trainerName){
        name = trainerName;
    }
    
    public PokeTrainer(string trainerName, int badges){
        name = trainerName;
        NumBadges = badges;
    }
    //private is another access modifier
    //private fields/methods/etc is only accessible by its owner
    //This is an example of field
    //We use field to contain data of trait of the class
    private string name;
    
    //ecample of a public getter to a private field
    public string GetName(){
        return name;
    }

    public void SetName(string nameToSet){
        //we can validate input data
        if(String.IsNullOrWhiteSpace(nameToSet)){
            //we'll do something
            Console.WriteLine("Hey, this is an invalid name.");
        }else{
            // We set the value we got passed in to the private field name
        this.name = nameToSet;
        }
        
    }

    //automatic property
    public int NumBadges{get;set;}

    public decimal Money {get;set;}
}
