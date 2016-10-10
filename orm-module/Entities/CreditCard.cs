using System;
using System.ComponentModel.DataAnnotations;

namespace orm_module.Entities
{
    public class CreditCard
    {
        [Key]
        public string CardNumber { get; set; }

        public DateTime ExpirationDate { get; set; }

        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
