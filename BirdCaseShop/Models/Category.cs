﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BirdCaseShop.Models
{
    public partial class Category
    {
        public Category()
        {
            CategoryProduct = new HashSet<CategoryProduct>();
        }

        [Key]
        [Column("CategoryID")]
        [StringLength(10)]
        public string CategoryId { get; set; }
        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        public bool IsCategory { get; set; }

        [InverseProperty("Category")]
        public virtual ICollection<CategoryProduct> CategoryProduct { get; set; }
    }
}