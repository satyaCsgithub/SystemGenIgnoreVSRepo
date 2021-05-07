﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmpDetail
    {
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        public string Location { get; set; }
        
        public string NativeID { get; set; }

        public string SatyaDB { get; set; }

        Public string GitIgnore { get; set; }
    }
}
