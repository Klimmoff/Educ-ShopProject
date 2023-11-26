using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Is42_2023.Data.Models
{
    class DocumentByService
    {
        public int Id { get; set; }
        public int ClientServiceId { get; set; }
        public string DocumentPath { get; set; }
    }
}
