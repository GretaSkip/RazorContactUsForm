﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorContactUsForm.Models
{
    public class ContactModel
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

    }
}
