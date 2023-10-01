using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_98_DESKTOP_MK2.Entities
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Data98Users")]
    public class User
    {
        [Key]
        public int ID { get; set; } = 0;
        public string Nickname { get; set; } = "NICKNAME_NON_ESTABLISHED";
        public string Email { get; set; } = "EMAIL_NON_ESTABLISHED";
        public string Phone { get; set; } = "PHONE_NON_ESTABLISHED";
        public string PassMD5 { get; set; } = "PASS_NON_ESTABLISHED";
        public string FirstName { get; set; } = "FIRSTNAME_NON_ESTABLISHED";
        public string LastName { get; set; } = "LASTNAME_NON_ESTABLISHED";
        public string MiddleName { get; set; } = "MIDDLENAME_NON_ESTABLISHED";
        public AccessLevel RightsType { get; set; } = AccessLevel.Customer;
        public bool Banned { get; set; } = false;
    }
}
