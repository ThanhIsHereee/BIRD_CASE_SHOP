﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BirdCaseShop.Models
{
    public partial class Image
    {
        [Key]
        [Column("ImageID")]
        [StringLength(10)]
        public string ImageId { get; set; }
        [Column("BlogID")]
        [StringLength(10)]
        public string BlogId { get; set; }
        [Column("ProductID")]
        [StringLength(10)]
        public string ProductId { get; set; }
        [Required]
        [Column("ImageURL")]
        public string ImageUrl { get; set; }

        [ForeignKey("BlogId")]
        [InverseProperty("Image")]
        public virtual Blog Blog { get; set; }
        [ForeignKey("ProductId")]
        [InverseProperty("Image")]
        public virtual Product Product { get; set; }
    }
}