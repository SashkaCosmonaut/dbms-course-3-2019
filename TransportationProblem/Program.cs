using System;
using System.Collections.Generic;
using TransportationProblem.DBModels;
using TransportationProblem.DBModels.JSON;

namespace TransportationProblem
{
    /// <summary>
    /// Класс точки входа в программу.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Словарь имеющихся моделей для взаимодействия с различными БД, 
        /// где ключ - название БД, значение - класс модели для работы с ней.
        /// </summary>
        public static Dictionary<string, IDBModel> DBModels = new Dictionary<string, IDBModel>
        {
            { "JSON", new JSONModel() }
        };

        /// <summary>
        /// Функция точки входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        public static void Main(string[] args)
        {
            try
            {
                var model = ChooseDB();

                if (model == null) return;

                if (!model.Init(AskForDBFile()))
                {
                    Console.WriteLine("Произошла ошибка инициализации БД!");
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка работы программы! " + ex.Message);
            }
        }

        /// <summary>
        /// Выбрать, с какой БД нужно работать, запросив это у пользователя.
        /// </summary>
        /// <returns>Модель выбранной БД.</returns>
        public static IDBModel ChooseDB()
        {
            try
            {
                Console.WriteLine("Выберете БД, введите её название из списка имеющихся:");

                foreach (var dbName in DBModels.Keys)
                    Console.WriteLine(dbName);

                var choice = Console.ReadLine();

                if (DBModels.ContainsKey(choice))   // Проверяем наличие БД с таким названием
                    return DBModels[choice];

                Console.WriteLine("Некорректное название БД!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        /// <summary>
        /// Спросить пользователя путь до файла с БД.
        /// </summary>
        /// <returns>Строка с путём до файла с БД.</returns>
        public static string AskForDBFile()
        {
            var path = "";

            try
            {
                Console.WriteLine("Введите путь до файла с БД или папки:");

                do
                {
                    path = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(path));  // Ждём пока не введут не пустую строку
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return path;
        }
    }
}
