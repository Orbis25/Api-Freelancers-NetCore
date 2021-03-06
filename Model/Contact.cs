﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string FromId { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

    }
}
