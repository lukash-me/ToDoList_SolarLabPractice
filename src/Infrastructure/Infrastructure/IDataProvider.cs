using Base;

namespace Infrastructure
{
    public interface IDataProvider
    {
        void saveData(Tasks task);
        string loadData();
    }
}
