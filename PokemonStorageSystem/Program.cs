using Models;
using CustomExceptions;
PokeTrainer trainer = new PokeTrainer();

//Doesn't work, access denied
trainer.SetName("Ash Ketchum");
Console.WriteLine(trainer.GetName());
// trainer.NumBadges(3);
// Console.WriteLine(trainer.NumBadges());
PokeTrainer anotherTrainer = new PokeTrainer("Brock");
Console.WriteLine(anotherTrainer.GetName());

//Object Initializer
int[] numArr = new int[10]{1,2,3,4,5,6,7,8,9,10};
PokeTrainer thirdTrainer = new PokeTrainer{
    NumBadges =3,
    Money = 10
};
Console.WriteLine(thirdTrainer.Money);
Console.WriteLine(thirdTrainer.GetName() + " has "+ thirdTrainer.Money+ " dollars.");
try{
    PokeTrainer test = new PokeTrainer();
    test.SetName("    ");
}catch(Exception ex){
    Console.WriteLine("caught Exception"+ex.Message);
}finally{
    Console.WriteLine("This is the Finally block");
}
Pokemon starter = new Pokemon("Pikachu","Thor");
Console.WriteLine(starter.Name+" is nicknamed "+ starter.NickName);