using TransportationProblem.Domain;

namespace TransportationProblem.DBModels
{
    /// <summary>
    /// Модель БД, которая для хранения данных использует JSON-файлы.
    /// </summary>
    public class JSONModel : IDBModel
    {
        /// <summary>
        /// Инициализировать БД, создать её, если ещё не создана, подключиться, если нужно
        /// и наполнить данными по умолчанию, если она была создана.
        /// </summary>
        /// <returns>True, если операция была выполнена успешно.</returns>
        public bool Init()
        {
            return false;
        }

        /// <summary>
        /// Получить все имеющиеся в БД задачи.
        /// </summary>
        /// <returns>Массив имеющихся задач.</returns>
        public Problem[] GetProblems()
        {
            return new Problem[] { };
        }

        /// <summary>
        /// Добавить новую задачу в БД.
        /// </summary>
        /// <param name="problem">Объект задачи для добавления.</param>
        public void AddProblem(Problem problem)
        {

        }

        /// <summary>
        /// Удалить существующую задачу из БД.
        /// </summary>
        /// <param name="problem">Объект удаляемой задачи.</param>
        public void DeleteProblem(Problem problem)
        {

        }
    }
}
