using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PRCS1.Models
{
    public class Patient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Result { get; set; }
        [Display(Name = "Report Delievered")]
        public string isDelivered { get; set; }
        [Display(Name = "Refered By")]
        public string ReferedBy { get; set; }
        [Display(Name = "Test Requested")]
        public string TestRequested { get; set; }
        public string Payment { get; set; }
    }
}