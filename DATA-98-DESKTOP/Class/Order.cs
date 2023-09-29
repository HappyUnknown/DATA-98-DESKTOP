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
    public class Order
    {
        [Key]
        public int Id { get; set; } = 0;
        public string ItemName { get; set; } = "NO_NAME";
        public string OrderDesc { get; set; } = "NO_DESCRIPTION";
        public string FaultName { get; set; } = Malfunction.Unsigned.ToString();
        public string DiagDesc { get; set; } = "NO_DIAGNOSTICS";
        public double FixPrice { get; set; } = -1;
        public string Conclusion { get; set; } = "NO_CONCLUSION";
        public AgreementState ApprovalPhase { get; set; } = AgreementState.Confirmation;
        public string MediaArray { get; set; } = "NO_MEDIA";
        public int MasterId { get; set; } = 0;
        public int CustomerId { get; set; } = 0;
    }
}
