using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace Trash_Collector.Models
{
    public class User
    {
        [Key]       
        public string ID { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        public string Address { get; set; }
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    
        public string RoleID { get; set; }

        [ForeignKey("ID")]
        public virtual ApplicationUser UserID { get; set; }
        
    }
}