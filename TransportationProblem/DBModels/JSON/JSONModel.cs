using Newtonsoft.Json;
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
        /// Путь до папки с JSON-файлами.
        /// </summary>
        protected string DirPath { get; set; }

        /// <summary>
        /// Инициализировать БД, создать её, если ещё не создана, подключиться, если нужно
        /// и наполнить данными по умолчанию, если она была создана.
        /// </summary>
        /// <param name="path"> Путь до БД - до папки с JSON-файлами.</param>
        /// <returns>True, если операция была выполнена успешно.</returns>
        public bool Init(string path)
        {
            DirPath = path;

            try
            {
                if (string.IsNullOrWhiteSpace(path)) return false;

                // Если в папке нет json-файлов, создаём один по умолчанию
                if (!Directory.GetFiles(path, "*.json", SearchOption.AllDirectories).Any())
                {
                    Console.WriteLine("БД пуста! Создана задача по умолчанию");

                    AddProblem(Problem.GetDefaultProblem());
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
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
                // Сериализуемый объект хранит только значения
                var result = new JSONProblem
                {
                    Name = problem.Name,
                    Consumers = problem.Consumers.Select(q => q.Demand).ToArray(),
                    Suppliers = problem.Suppliers.Select(q => q.Capacity).ToArray(),
                    Costs = new int[problem.Suppliers.Length, problem.Consumers.Length]
                };

                // Преобразуем стоимости из массива в матрицу
                var height = problem.Suppliers.Length;
                var width = problem.Consumers.Length;

                for (int i = 0; i < height; i++)
                    for (int j = 0; j < width; j++)
                        result.Costs[i, j] = problem.Routes[i * width + j].Cost;

                return result;
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
                var result = new Problem
                {
                    Name = problem.Name,
                    Consumers = problem.Consumers.Select(q => new Consumer { Name = "B", Demand = q }).ToArray(),
                    Suppliers = problem.Suppliers.Select(q => new Supplier { Name = "A", Capacity = q}).ToArray(),
                };

                var height = problem.Suppliers.Length;
                var width = problem.Consumers.Length;

                var routes = new Route[height * width];

                for (int i = 0; i < height; i++)
                    for (int j = 0; j < width; j++)
                    {
                        routes[i * width + j] = new Route
                        {
                            Supplier = result.Suppliers[i],
                            Consumer = result.Consumers[j],
                            Cost = problem.Costs[i, j]
                        };
                    }

                result.Routes = routes;

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        /// <summary>
        /// Получить все имеющиеся в БД задачи.
        /// </summary>
        /// <returns>Массив имеющихся задач.</returns>
        public Problem[] GetProblems()
        {
            try
            {
                return Directory.GetFiles(DirPath, "*.json", SearchOption.AllDirectories)
                    .Select(filename => FromJsonProblem(JsonConvert.DeserializeObject<JSONProblem>(File.ReadAllText(filename))))
                    .ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return new Problem[] { };
            }           
        }

        /// <summary>
        /// Добавить новую задачу в БД.
        /// </summary>
        /// <param name="problem">Объект задачи для добавления.</param>
        public void AddProblem(Problem problem)
        {
            try
            {
                File.WriteAllText(
                    Path.Combine(DirPath, problem.Name + ".json"),          // Создаём новый файл или перезаписываем старый
                    JsonConvert.SerializeObject(ToJsonProblem(problem)));   // Преобразуем объект задачи в сериализуемый объект и сериализуем
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
