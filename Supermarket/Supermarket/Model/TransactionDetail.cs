﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Model
{
    public class TransactionDetail
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public double Tax { get; set; }
        public int Quantity { get; set; }
        public double Subtotal { get; set; }
        public Product product { get; set; }
        public Transaction Transaction { get; set; }
    }
}