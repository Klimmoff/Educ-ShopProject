using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Is42_2023.Data.Models
{
    class ClientService
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ServiceId { get; set; }
        public DateTime StartTime { get; set; }
        public string Comment { get; set; }
        public int ProductSaleId { get; set; }
        public List<DocumentByService> DocumentByServices { get; set; } = new List<DocumentByService>();
    }
}
