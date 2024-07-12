using Base;

namespace Infrastructure
{
    public interface IDataProvider
    {
        /// <summary>
        /// Сохранение данных.
        /// </summary>
        /// <param name="strList">Строковый список задач.</param>
        void saveData(List<string> strList);
        /// <summary>
        /// Загрузка данных.
        /// </summary>
        /// <returns>Строковый список задач.</returns>
        List<string> loadData();
    }
}
