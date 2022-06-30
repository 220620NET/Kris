namespace DataAccess;
using System.Text.Json;
using Models;
public class PKMNTrainerRepository{
    //This class is responsible for persisting the information

    //In this particular instance, we'll be using json file to persist our data

    private const string filePath = "../DataAccess/trainerRegistry.json";
    public Dictionary<string,PKMNTrainer> GetAllTrainers(){
        string fileString = File.ReadAllText(filePath);
        try{
            return JsonSerializer.Deserialize<Dictionary<string,PKMNTrainer>>(fileString);
        }
        catch(JsonException){
            throw;
        }
    }
    public PKMNTrainer GetTrainerByName(string name){
        try{
            Dictionary<string,PKMNTrainer> allTrainers=GetAllTrainers();
            return allTrainers[name];
        }
        catch(JsonException){
            throw;
        }
    }
    public PKMNTrainer AddTrainer(PKMNTrainer newTrainer){
        //Here, I'm Deserializing the string to a type of C# object that rest of the application can use
        //Serialization is a process of converting data into stream of bytes to be transported elsewhere
        // In here, we are converting our C# objects to stream of bytes, so we can save it into a file
        //The data can be serialized into byteStream, characterStream
        try{
            Dictionary<string,PKMNTrainer> allTrainers=GetAllTrainers();
            allTrainers.Add(newTrainer.name,newTrainer);
            File.WriteAllText(filePath,JsonSerializer.Serialize(allTrainers));

            return newTrainer;
        }
        catch(JsonException){
            throw;
        }
    }
}