using Models;

PokeTrainer trainer = new PokeTrainer();

//Doesn't work, access denied
trainer.SetName("Ash Ketchum");
Console.WriteLine(trainer.GetName());
// trainer.NumBadges(3);
// Console.WriteLine(trainer.NumBadges());