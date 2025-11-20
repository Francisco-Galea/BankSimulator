namespace BankSimulator.Repositories
{
    internal interface IRepository<T>
    {
        void SaveData(T genericClass);
        List<T> LoadAllData();
    }
}
