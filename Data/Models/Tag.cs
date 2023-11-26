using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Is42_2023.Data.Models
{
    class Tag
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }
        public List<TagOfClient> TagOfClients { get; set; } = new List<TagOfClient>();
    }
}
