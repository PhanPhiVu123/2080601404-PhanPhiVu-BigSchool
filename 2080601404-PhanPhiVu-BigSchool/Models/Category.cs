using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _2080601404_PhanPhiVu_BigSchool.Models
{
    public class Category
    {
            public byte Id { get; set; }
            [Required]
            [StringLength(255)]
            public string Name { get; set; }
        }
    }