using System;

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

        /// <summary>
        /// Сформировать задачу по умолчанию.
        /// </summary>
        /// <returns>Объект со свойствами задачи по умолчанию.</returns>
        public static Problem GetDefaultProblem()
        {
            try
            {
                var consumerName = "B";
                var supplierName = "A";

                var consumers = new[]
                {
                    new Consumer { Name = consumerName, Demand = 18 },
                    new Consumer { Name = consumerName, Demand = 27 },
                    new Consumer { Name = consumerName, Demand = 42 },
                    new Consumer { Name = consumerName, Demand = 15 },
                    new Consumer { Name = consumerName, Demand = 26 }
                };

                var suppliers = new[]
                {
                    new Supplier{ Name = supplierName, Capacity = 30 },
                    new Supplier{ Name = supplierName, Capacity = 48 },
                    new Supplier{ Name = supplierName, Capacity = 20 },
                    new Supplier{ Name = supplierName, Capacity = 30 }
                };

                return new Problem
                {
                    Name = "Задача по умолчанию",
                    Consumers = consumers,
                    Suppliers = suppliers,
                    Routes = new[]
                    {
                        new Route{ Consumer = consumers[0], Supplier = suppliers[0], Cost = 13 },
                        new Route{ Consumer = consumers[1], Supplier = suppliers[0], Cost = 7 },
                        new Route{ Consumer = consumers[2], Supplier = suppliers[0], Cost = 14 },
                        new Route{ Consumer = consumers[3], Supplier = suppliers[0], Cost = 7 },
                        new Route{ Consumer = consumers[4], Supplier = suppliers[0], Cost = 5 },
                        new Route{ Consumer = consumers[0], Supplier = suppliers[1], Cost = 11 },
                        new Route{ Consumer = consumers[1], Supplier = suppliers[1], Cost = 8 },
                        new Route{ Consumer = consumers[2], Supplier = suppliers[1], Cost = 12 },
                        new Route{ Consumer = consumers[3], Supplier = suppliers[1], Cost = 6 },
                        new Route{ Consumer = consumers[4], Supplier = suppliers[1], Cost = 8 },
                        new Route{ Consumer = consumers[0], Supplier = suppliers[2], Cost = 6 },
                        new Route{ Consumer = consumers[1], Supplier = suppliers[2], Cost = 10 },
                        new Route{ Consumer = consumers[2], Supplier = suppliers[2], Cost = 10},
                        new Route{ Consumer = consumers[3], Supplier = suppliers[2], Cost = 8 },
                        new Route{ Consumer = consumers[4], Supplier = suppliers[2], Cost = 11 },
                        new Route{ Consumer = consumers[0], Supplier = suppliers[3], Cost = 14 },
                        new Route{ Consumer = consumers[1], Supplier = suppliers[3], Cost = 8 },
                        new Route{ Consumer = consumers[2], Supplier = suppliers[3], Cost = 10 },
                        new Route{ Consumer = consumers[3], Supplier = suppliers[3], Cost = 10 },
                        new Route{ Consumer = consumers[4], Supplier = suppliers[3], Cost = 15 },
                    }
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }
    }
}
