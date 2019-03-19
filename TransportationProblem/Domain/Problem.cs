namespace TransportationProblem.Domain
{
    /// <summary>
    /// Задача, решение которой необходимо найти.
    /// </summary>
    public class Problem
    {
        /// <summary>
        /// Наименование задачи.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Множество путей, соединяющих определённых поставщиков и потребителей 
        /// в данной задаче, образующих матрицу путей.
        /// </summary>
        public Route[] Routes { get; set; }
    }
}
