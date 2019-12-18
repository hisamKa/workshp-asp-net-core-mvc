using SalesWebMvc.Models.Enums;
using System;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        private int v1;
        private DateTime dateTime;
        private double v2;
        private SaleStatus billed;
        private Seller s1;

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

        //Adicionou esse construtor pq deu erro ao adc Recorde de vendas
        public SalesRecord(int v1, DateTime dateTime, double v2, SaleStatus billed, Seller s1)
        {
            this.v1 = v1;
            this.dateTime = dateTime;
            this.v2 = v2;
            this.billed = billed;
            this.s1 = s1;
        }
    }
}
