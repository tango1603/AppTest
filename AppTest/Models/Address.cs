using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppTest.Models
{
    public class Address
    {
        // ID 
        public int Id { get; set; }
        // Страна
        public string Country { get; set; }
        // Город
        public string City { get; set; }
        // Улица
        public string Stereet { get; set; }
        // Номер дома
        public int BuildingNumber { get; set; }
        // Индекс
        public string PostID { get; set; }
        // Дата и время
        public string DateTime { get; set; }
    }
}