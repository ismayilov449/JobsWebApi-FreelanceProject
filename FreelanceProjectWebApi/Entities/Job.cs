﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreelanceProject.Models
{
    public class Job
    {

        public int Id { get; set; }

        public Client Client { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string RequiredSkills { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Price { get; set; }

        [Required]
        public string Education { get; set; }

        [Required]
        public string Experience { get; set; }

        [Required]
        public string Age { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Position { get; set; }

        public DateTime SharedTime { get; set; }

        [Required]
        public DateTime Deadline { get; set; }

        public Guid Token { get; set; }

        [Required]
        public bool IsPublished { get; set; }

        [Required]
        public bool IsApproved { get; set; }

        [Required]
        public bool FirstRequest { get; set; }
    }
}
