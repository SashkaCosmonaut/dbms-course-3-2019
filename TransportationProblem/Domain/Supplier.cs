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

        /// <summary>
        /// Значение высланного объема, которое в итоге должно стать равным доступному объёму.
        /// </summary>
        public double Sent { get; set; }
    }
}
