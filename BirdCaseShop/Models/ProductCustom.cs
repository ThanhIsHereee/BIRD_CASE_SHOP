﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BirdCaseShop.Models
{
    public partial class ProductCustom
    {
        [Key]
        [Column("ProductCustomID")]
        [StringLength(10)]
        public string ProductCustomId { get; set; }
        [StringLength(50)]
        public string ProductName { get; set; }
        [StringLength(10)]
        public string ProductSize { get; set; }
        [StringLength(10)]
        public string ProductColor { get; set; }
        [StringLength(10)]
        public string ProductMaterial { get; set; }
        [StringLength(10)]
        public string ProductStyle { get; set; }
        [Required]
        [Column("UserID")]
        [StringLength(10)]
        public string UserId { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Price { get; set; }

        [ForeignKey("ProductColor")]
        [InverseProperty("ProductCustom")]
        public virtual Color ProductColorNavigation { get; set; }
        [ForeignKey("ProductMaterial")]
        [InverseProperty("ProductCustom")]
        public virtual Material ProductMaterialNavigation { get; set; }
        [ForeignKey("ProductSize")]
        [InverseProperty("ProductCustom")]
        public virtual Size ProductSizeNavigation { get; set; }
        [ForeignKey("ProductStyle")]
        [InverseProperty("ProductCustom")]
        public virtual Style ProductStyleNavigation { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("ProductCustom")]
        public virtual User User { get; set; }
    }
}