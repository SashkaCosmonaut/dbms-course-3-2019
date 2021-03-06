﻿using TransportationProblem.Domain;

namespace TransportationProblem.DBModels
{
    /// <summary>
    /// Интерфейс, задающий поведение классам моделей БД.
    /// </summary>
    public interface IDBModel
    {
        /// <summary>
        /// Инициализировать БД, создать её, если ещё не создана, подключиться, если нужно
        /// и наполнить данными по умолчанию, если она была создана.
        /// </summary>
        /// <param name="path">Путь до файла БД.</param>
        /// <returns>True, если операция была выполнена успешно.</returns>
        bool Init(string path);

        /// <summary>
        /// Получить все имеющиеся в БД задачи.
        /// </summary>
        /// <returns>Массив имеющихся задач.</returns>
        Problem[] GetProblems();

        /// <summary>
        /// Добавить новую задачу в БД.
        /// </summary>
        /// <param name="problem">Объект задачи для добавления.</param>
        void AddProblem(Problem problem);

        /// <summary>
        /// Удалить существующую задачу из БД.
        /// </summary>
        /// <param name="problem">Объект удаляемой задачи.</param>
        void DeleteProblem(Problem problem);
    }
}
