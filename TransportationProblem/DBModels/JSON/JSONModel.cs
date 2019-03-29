using System;
using System.IO;
using System.Linq;
using TransportationProblem.Domain;

namespace TransportationProblem.DBModels.JSON
{
    /// <summary>
    /// Модель БД, которая для хранения данных использует JSON-файлы.
    /// </summary>
    public class JSONModel : IDBModel
    {
        /// <summary>
        /// Сформировать задачу по умолчанию.
        /// </summary>
        /// <returns>Объект со свойствами задачи по умолчанию.</returns>
        protected Problem GetDefaultProblem()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        /// <summary>
        /// Преобразовать объект задачи в объект, который будет сериализоваться.
        /// </summary>
        /// <param name="problem">Объект задачи.</param>
        /// <returns>Объект сериализуемой задачи.</returns>
        public JSONProblem ToJsonProblem(Problem problem)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        /// <summary>
        /// Преобразовать объект задачи из сериализуемого объекта задачи.
        /// </summary>
        /// <param name="problem">Объект сериализуемой задачи.</param>
        /// <returns>Объект задачи.</returns>
        public Problem FromJsonProblem(JSONProblem problem)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        /// <summary>
        /// Инициализировать БД, создать её, если ещё не создана, подключиться, если нужно
        /// и наполнить данными по умолчанию, если она была создана.
        /// </summary>
        /// <param name="path"> Путь до БД - до папки с JSON-файлами.</param>
        /// <returns>True, если операция была выполнена успешно.</returns>
        public bool Init(string path)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(path)) return false;

                var files = Directory.GetFiles(path, "*.json", SearchOption.AllDirectories);

                if (!files.Any())
                {
                    Console.WriteLine("БД пуста! Создана задача по умолчанию");

                    AddProblem(GetDefaultProblem());

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

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
