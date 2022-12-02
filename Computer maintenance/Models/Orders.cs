using System.ComponentModel.DataAnnotations;

namespace Computer_maintenance.Models
{
    public class Orders
    {
        // Id = 1, ComputerType = MSI Aegis, Order = PC not turning on, Price = 300$, Client = Erik, CompletionDate = 20/12/2022, Paid = No
        public int Id { get; set; }

        public string? ComputerType { get; set; }

        public string? OrderName { get; set; }

        public decimal Price { get; set; }

        public string? Client { get; set; }

        [DataType(DataType.Date)]
        public DateTime CompletionDate { get; set; }

        public bool Paid { get; set; }
    }
}
