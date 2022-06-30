// Inheritance
Sheep baa=new Sheep();
Console.WriteLine(baa.TypeOfCoat);
baa.ChangeType();
Console.WriteLine(baa.TypeOfCoat);
public abstract class Animal{
    public Animal(){}

    public string Species{get;set;}
    // public getter, private setter
    public int NumberOfLimbs{get;private set;}
    // Example of using custom defined Enum
    //readonly
    public Covering TypeOfCoat {get;set;}
    //abstract method Lacks the method body
    //It is implicitly virtual
    public abstract string MakeNoise();
    //Concrete method that is overridable
    public virtual string Move(){return "Animal Moves";}

}
public enum Covering{Feather,Fur,Scale,Wool}
public class Sheep:Animal{
    public Sheep(){
        TypeOfCoat=(Covering)3;
    }
    internal void ChangeType(){
        TypeOfCoat =(Covering)2;
    }
    public override string MakeNoise(){
        return "baa";
    }
    private const string eyeColor ="brown";
}

