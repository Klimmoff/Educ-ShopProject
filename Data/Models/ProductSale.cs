using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Is42_2023.Data.Models
{
    class ProductSale
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int ClientServiceId { get; set; }
        public List<ClientService> ClientServices { get; set; } = new List<ClientService>();

    }
}
