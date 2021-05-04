﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
    [Table("Errors")]
    public class Error
    {
        [Key]
        public int Id { set; get; }

        public string Message { set; get; }

        public string StackTrace { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
