using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Trash_Collector.Models
{
    public class CustomerAccount
    {
        [Key]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
        [Display(Name ="Pickup Day")]
        public string PickupDay { get; set; }
        [Display(Name = "Extra Day")]
        public string ExtraPickup { get; set; }
        [Display(Name ="Amount Due")]
        public double AmountDue { get; set; }
    }
}