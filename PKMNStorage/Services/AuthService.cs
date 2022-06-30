using DataAccess;
using Models;
using System.Text.Json;
using CustomExceptions;
namespace Services;


public class AuthService{
    public PKMNTrainer Register(PKMNTrainer newTrainer){
        //If you want to keep your name unique in your registry , you can check for duplicates
        //
        try{
            PKMNTrainer duplicateCheck= new PKMNTrainerRepository().GetTrainerByName(newTrainer.name);
            if (duplicateCheck!=null){
                throw new DuplicateRecordException();
            }
            return new PKMNTrainerRepository().AddTrainer(newTrainer);
        }catch(JsonException){
            throw;
        }
        
    }
}