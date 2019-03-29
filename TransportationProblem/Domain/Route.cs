namespace TransportationProblem.Domain
{
    /// <summary>
    /// Путь, соединяющий поставщика и потребителя.
    /// </summary>
    public class Route
    {
        /// <summary>
        /// Поставщик из которого поставляется продукция.
        /// </summary>
        public Supplier Supplier { get; set; }

        /// <summary>
        /// Потребитель, в которого поставляется продукция.
        /// </summary>
        public Consumer Consumer { get; set; }

        /// <summary>
        /// Стоимость передачи единицы продукции по данному пути.
        /// </summary>
        public int Cost { get; set; }

        /// <summary>
        /// Объем поставки продукции по данному пути.
        /// </summary>
        public int Volume { get; set; }

        /// <summary>
        /// Получить строковое представление данного пути.
        /// </summary>
        /// <returns>Строка с описанием данного пути.</returns>
        public override string ToString()
        {
            return $"{Supplier} {Consumer}: {Volume}, {Cost}";
        }
    }
}
