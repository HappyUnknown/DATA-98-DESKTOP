using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_98_DESKTOP.Class
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Masters")]
    public class Master : Customer
    {
        //[Key]
        //public int Id { get; set; }
        //public string Email { get; set; }
        //public string Phone { get; set; }
        //public string PassMD5 { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string MiddleName { get; set; }
        //public string ContactLine { get; set; }
        public AccessLevel RightsType { get; set; }
    }
}
