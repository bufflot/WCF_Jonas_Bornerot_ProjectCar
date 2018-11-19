﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClasses
{
    public class BaseEntity
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public void GetDate()
        {
            CreatedOnUtc = DateTime.UtcNow;

        }


    }
}
