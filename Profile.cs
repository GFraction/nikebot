using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace nikebot
{
    [Serializable]
    public class Profile
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Apt { get; set; }
        public string Email { get; set; }
        public string CreditCard { get; set; }
        public string CVV { get; set; }
    }
}
