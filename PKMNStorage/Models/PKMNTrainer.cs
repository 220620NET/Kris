using CustomExceptions;
namespace Models;

public class PKMNTrainer
{
    public PKMNTrainer(){
        NumBadges =0;
        Money=0;
    }

    public PKMNTrainer(string trainerName){
        NumBadges = 0;
        Money=0; 
        name=trainerName;
    }

    public PKMNTrainer(string trainerName,int badges){
        name=trainerName;
        NumBadges=badges;
        Money=0;
    }

    private string name;
    public string GetName(){
        return name;
    }
    public void SetName(string nameToSet){
        if(String.IsNullOrWhiteSpace(nameToSet)){
            throw new InputInvalidException("the name is invalid");
        }else{
            this.name= nameToSet;
        }
    }
    public int NumBadges{get;set;}
    public decimal Money{get;set;}
    public DateOnly DoB{get;set;}
    public int Id{get;set;}
    public override string ToString(){
        return$"Name:{this.name} \nNumBadges: {this.NumBadges} \nMoney: {Money}";
    }
}
