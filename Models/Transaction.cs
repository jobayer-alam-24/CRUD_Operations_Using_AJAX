using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Operations_Using_AJAX.Models
{
    public class Transaction
    {
        public Transaction() { }

        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(8)")]
        public string SWIFT_Code { get; set; }

        public int Amount { get; set; }

    }
}
