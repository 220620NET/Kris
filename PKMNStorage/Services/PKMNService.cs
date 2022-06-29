using Models;
using DataAccess;

namespace Services;
public class PKMNService
{
    public void Register(PKMNTrainer trainerToRegister){
        PKMNStorage.TrainerRegistry[PKMNStorage.RegistrySize]=trainerToRegister;
        PKMNStorage.RegistrySize++;
    }

    public PKMNTrainer FindTrainer(Predicate<PKMNTrainer> searchCriteria){
        try{
            return Array.Find(PKMNStorage.TrainerRegistry, searchCriteria);
        }catch(ArgumentNullException ex){
            throw;
        }
    }
}
