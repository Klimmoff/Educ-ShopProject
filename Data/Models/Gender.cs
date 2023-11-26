using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Is42_2023.Data.Models
{
    class Gender
    {
        public int GenderId { get; set; }
        public string Name { get; set; }
        public List<Client> Clients { get; set; } = new List<Client>();
    }
}
