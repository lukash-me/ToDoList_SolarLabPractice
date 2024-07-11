using Base;

namespace Infrastructure
{
    public interface IDataProvider
    {
        void saveData(List<string> strList);
        List<string> loadData();
    }
}
