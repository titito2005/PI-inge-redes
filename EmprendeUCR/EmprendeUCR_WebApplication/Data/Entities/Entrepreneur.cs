﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmprendeUCR_WebApplication.Data.Entities
{
    public class Entrepreneur
    {
        [Key]
        public string User_Email { get; set; }
        public string Presentation { get; set; }

    }
}
