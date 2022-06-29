using Models;

namespace DataAccess;
public static class PKMNStorage{
    public static PKMNTrainer[] TrainerRegistry{get;set;}= new PKMNTrainer[10];
    
    //Informs the size of the registry
    public static int RegistrySize{get;set;}=0;
}
