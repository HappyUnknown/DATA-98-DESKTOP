using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_98_DESKTOP.Class
{
    [Table("Orders")]
    class Order
    {
        [Key]
        public int Id { get; set; } = 0;
        public string OrderDesc { get; set; } = "NO_OD";
        public Malfunction FaultType { get; set; } = Malfunction.BadBattery;
        public string DiagDesc { get; set; } = "NO_DD";
        public double FixPrice { get; set; } = -1;
        public string Conclusion { get; set; } = "NO_CONCLUSION";
        public AgreementState ApprovalPhase { get; set; } = AgreementState.Unapproved;
        public string MediaArray { get; set; } = "NO_ARRAY";
        public int MasterId { get; set; } = 0;
        public int CustomerId { get; set; } = 0;
    }
}
