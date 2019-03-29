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

        /// <summary>
        /// Множество всех поставщиков в задаче.
        /// </summary>
        public Supplier[] Suppliers { get; set; }

        /// <summary>
        /// Множество всех потребителей в задаче.
        /// </summary>
        public Consumer[] Consumers { get; set; }
    }
}
