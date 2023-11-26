using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Is42_2023.Data.Models
{
    class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int GenderId { get; set; }
        public string PhotoPath { get; set; }

        public List<TagOfClient> TagOfClients { get; set; } = new List<TagOfClient>();
        public List<ClientService> ClientServices { get; set; } = new List<ClientService>();
    }
}
