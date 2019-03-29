namespace TransportationProblem.DBModels.JSON
{
    /// <summary>
    /// Класс задачи, который будет сериализован и десериализован в JSON-файл.
    /// </summary>
    public class JSONProblem
    {
        /// <summary>
        /// Наименование задачи.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Массив объемов производства поставщиков.
        /// </summary>
        public int[] Suppliers { get; set; }

        /// <summary>
        /// Массив требуемых объемов потребителей.
        /// </summary>
        public int[] Consumers { get; set; }

        /// <summary>
        /// Матрица стоимостей путей.
        /// </summary>
        public int[,] Costs { get; set; }
    }
}
