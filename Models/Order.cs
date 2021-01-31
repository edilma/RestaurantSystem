﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSystem.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public int OrderProductsID { get; set; }
        public DateTime OrderReceivedDate { get; set; }
        public double OrderTipAmount { get; set; }
        public OrderStatus Status { get; set; }

        public Order() { }
        public Order(int aCustomerID, int anEmployeeID, int anOrderProductsID,DateTime anOrderReceivedDate, double anOrderTipAmount, OrderStatus aStatus )
        {
            CustomerID = aCustomerID;
            EmployeeID = anEmployeeID;
            OrderProductsID = anOrderProductsID;
            OrderReceivedDate = anOrderReceivedDate;
            OrderTipAmount = anOrderTipAmount;
            Status = aStatus;

        }

    }
}
