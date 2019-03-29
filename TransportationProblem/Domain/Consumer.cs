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
        public int Demand { get; set; }

        /// <summary>
        /// Значение полученного объёма, которое в итоге должно стать равным требуемому.
        /// </summary>
        public int Received { get; set; }

        /// <summary>
        /// Получить строковое представление данного потребителя.
        /// </summary>
        /// <returns>Строка с описанием данного потребителя.</returns>
        public override string ToString()
        {
            return $"{Name}({Received}/{Demand})";
        }
    }
}
