﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EFModels.Models
{
    public partial class Return
    {
        public int ID { get; set; }
        public DateTime? 退貨日期 { get; set; }
        public int? fk訂單 { get; set; }
        public string? 退貨轉帳帳號 { get; set; }
        public bool? 退款狀態 { get; set; }
        public int? 退貨理由 { get; set; }

        public virtual order fk訂單Navigation { get; set; }
        public virtual ReturnReson 退貨理由Navigation { get; set; }
    }
}