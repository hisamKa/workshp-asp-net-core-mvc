﻿using SalesWebMvc.Models.Enums;
using System;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public int MyProperty { get; set; }
        public Seller Seller { get; set; }//Associação


        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, int myProperty, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            MyProperty = myProperty;
            Seller = seller;
        }
    }
}
