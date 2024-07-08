using Base;

namespace Infrastructure
{
    public interface IDataProvider
    {
        void saveData(List<Tasks> taskList);
        void loadData(List<Tasks> taskList);
    }
}
