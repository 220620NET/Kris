namespace Models;
public class PKMN{
    public PKMN(){}
    public PKMN(string name){
        pkmnName = name;
    }

    private string pkmnName;
    public string GetPKMNName(){return pkmnName;}
    public void SetPKMNName(string newName){

        if(pkmnName.Length>0 && pkmnName.Length <=100){
            pkmnName =newName;
        }        
    }

    public string Name{
        get{
            return Name;
        }set{
            if(value.Length>0&&value.Length<=100){
                Name=value;
            }
        }
    }

    private int level;
    
    public int GetLevel(){return level;}
    public void SetLevel(int newLevel){level=newLevel;}

    public int Level{get;set;}

    public int TrainerId{get;set;}
    public string Type{get;set;}
    public string NickName{get;set;}
    public int Id{get;set;}
}