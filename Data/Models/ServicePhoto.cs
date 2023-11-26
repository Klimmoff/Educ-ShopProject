using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Is42_2023.Data.Models
{
    class ServicePhoto
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public string PhotoPath { get; set; }
    }
}
