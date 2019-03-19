namespace TransportationProblem.Domain
{
    /// <summary>
    /// Класс поставщика.
    /// </summary>
    public class Supplier
    {
        /// <summary>
        /// Наименование поставщика.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Доступный объем поставок поставщика.
        /// </summary>
        public double Capacity { get; set; }
    }
}
