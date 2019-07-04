using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace schoolSIMS.Model
{
    [Table("students")]
    public partial class Students
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("first_name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Column("middle_name")]
        [StringLength(50)]
        public string MiddleName { get; set; }
        [Column("last_name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Column("phone_number")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [Column("home_address")]
        [StringLength(100)]
        public string HomeAddress { get; set; }
        [Column("mailing_address")]
        [StringLength(100)]
        public string MailingAddress { get; set; }
        [Column("upi_username")]
        [StringLength(20)]
        public string UpiUsername { get; set; }
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("dob", TypeName = "date")]
        public DateTime? Dob { get; set; }
        [Column("date_created", TypeName = "date")]
        public DateTime? DateCreated { get; set; }
    }
}
