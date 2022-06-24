namespace Models;

public class Pokemon{
    public Pokemon(){}
    public Pokemon(string name,string nick){
        Name = name;
        NickName = nick;
    }
    public string Name{get;set;}
    public string NickName{get;set;}
    public string Type1{get;set;}
    public string Type2{get;set;}
    public string CaughtLocation{get;set;}
    public int Friendship{get;set;}
}
public class Mug{
    public Mug(){}
    public Mug(string material){
        Material = material;
    }
    public Mug(int vol, string mugColor, string mat){
        Volume = vol;
        Color= mugColor;
        Material=mat;
    }
    public int Id{get;set;}
    public int Volume{get;set;}
    public string Color{get;set;}
    public string Material{get;set;}
}