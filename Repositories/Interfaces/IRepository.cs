namespace BankSimulator.Repositories.Interfaces
{
    internal interface IRepository<T>
    {
        void SaveData(T genericClass);
        List<T> LoadAllData();
    }
}
