namespace TransportationProblem.Domain
{
    /// <summary>
    /// Класс потребителя.
    /// </summary>
    public class Consumer
    {
        /// <summary>
        /// Наименование потребителя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тебуемый объем поставок для потребителя.
        /// </summary>
        public double Demand { get; set; }

        /// <summary>
        /// Значение полученного объёма, которое в итоге должно стать равным требуемому.
        /// </summary>
        public double Received { get; set; }
    }
}
