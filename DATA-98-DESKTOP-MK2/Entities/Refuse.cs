using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_98_DESKTOP_MK2.Entities
{
    [Table("Refuses")]
    class Refuse
    {
        [Key]
        public int Id { get; set; } = 0;
        public int OrderId { get; set; }
        public int UserId { get; set; } = 0;
        public DateTime MomentRefused { get; set; } = DateTime.MinValue;
    }
}
