using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.Models
{
    public class PurchaseTempMV
    {
        public int PurTemID { get; set; }
        [Required(ErrorMessage = "Select Book")]
        public int BookID { get; set; }
        [Required(ErrorMessage = "Select Purchase Qty")]
        public int Qty { get; set; }
        [Required(ErrorMessage = "Select Purchase Unit Price")]
        public int UnitPrice { get; set; }

    }
}