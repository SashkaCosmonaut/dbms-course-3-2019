using System;
using System.Collections.Generic;
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
        /// Задача по умолчанию, которая создаётся, если БД пуста.
        /// </summary>
        protected JSONProblem DefaultProblem { get; set; } = new JSONProblem
        {
            Name = "Задача по умолчанию",
            Suppliers = new[] { 30, 48, 20, 30 },
            Consumers = new[] { 18, 27, 42, 15, 26 },
            Costs = new[,]
            {
                { 13, 7, 14, 7, 5 },
                { 11, 8, 12, 6, 8 },
                { 6, 10, 10, 8, 11 },
                { 14, 8, 10, 10, 15 }
            }
        };

        /// <summary>
        /// Считываемые из БД задачи.
        /// </summary>
        protected List<Problem> Problems = new List<Problem>();

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

                if (!files.Any()) return false;
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
