using Base;

namespace Infrastructure
{
    public interface IDataProvider
    {
        void saveData(Tasks task);
        void loadData(Tasks task);
    }
}
