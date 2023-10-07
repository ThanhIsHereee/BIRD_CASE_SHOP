﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BirdCaseShop.Models
{
    public partial class VoucherUserOrder
    {
        [Key]
        [Column("VoucherID")]
        [StringLength(10)]
        public string VoucherId { get; set; }
        [Key]
        [Column("OrderID")]
        [StringLength(10)]
        public string OrderId { get; set; }
        [Key]
        [Column("UserID")]
        [StringLength(10)]
        public string UserId { get; set; }
        [Column(TypeName = "date")]
        public DateTime UseDate { get; set; }
        public bool Status { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("VoucherUserOrder")]
        public virtual Order Order { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("VoucherUserOrder")]
        public virtual User User { get; set; }
        [ForeignKey("VoucherId")]
        [InverseProperty("VoucherUserOrder")]
        public virtual Voucher Voucher { get; set; }
    }
}