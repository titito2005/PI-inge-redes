﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprendeUCR.Domain.Core.CoreEntities
{
    public class ProductService
    {
        public int Code_ID { get; set; }

        public string Entrepreneur_Email { get; set; }
        public int Category_ID { get; set; }
        public Byte Availability { get; set; }
    }
}
