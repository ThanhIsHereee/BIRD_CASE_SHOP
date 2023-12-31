﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BirdCaseShop.Models
{
    public partial class ColorProduct
    {
        [Key]
        [Column("ProductID")]
        [StringLength(10)]
        public string ProductId { get; set; }
        [Key]
        [Column("ColorID")]
        [StringLength(10)]
        public string ColorId { get; set; }
        public bool Status { get; set; }

        [ForeignKey("ColorId")]
        [InverseProperty("ColorProduct")]
        public virtual Color Color { get; set; }
        [ForeignKey("ProductId")]
        [InverseProperty("ColorProduct")]
        public virtual Product Product { get; set; }
    }
}