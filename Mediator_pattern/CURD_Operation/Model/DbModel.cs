﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD_Operation.Model
{

    public class Departments
    {
        [Key]
        public int StudId { get; set; }
        public string StudName { get; set; }
        public int StudAge { get; set; }
        public int StudFees { get; set; }

    }
   

}
