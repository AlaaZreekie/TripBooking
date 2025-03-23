﻿using DataAccessLayer.Entities.Common;
using DataAccessLayer.Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Payment : BaseEntity
    {
        public Payment()
        {
            PaymentTransactions = new HashSet<PaymentTransaction>();
        }
        public int BookingId { get; set; }
        public PaymentStatusEnum Status { get; set; }
        public decimal AmountDue { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Notes { get; set; } = string.Empty;
        public Booking? Booking { get; set; } // Navigation
        public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; }
    }
}
