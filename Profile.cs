using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikebot
{
    class Profile
    {
        public int ID { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Surname { get; set; }
        [StringLength(255)]
        public string Patronymic { get; set; }
        [StringLength(255)]
        public string Phone { get; set; }
        [StringLength(255)]
        public string City { get; set; }
        [StringLength(255)]
        public string Street { get; set; }
        [StringLength(255)]
        public string Apt { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string CreditCard { get; set; }
        [StringLength(255)]
        public string CVV { get; set; }
    }
}
