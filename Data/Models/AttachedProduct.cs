using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Is42_2023.Data.Models
{
    class AttachedProduct
    {
        public int Id { get; set; }
        public int MainProductId { get; set; }
        public int ProductId { get; set; }
    }
}
