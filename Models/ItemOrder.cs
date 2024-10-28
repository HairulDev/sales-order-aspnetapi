﻿using System;
namespace sales_order_restapi.Models
{
	public class ItemOrder
	{
		public ItemOrder()
		{
		}
	}
}

namespace SalesOrderApi.Models
{
    public class ItemOrder
    {
        public string? Id_Item { get; set; }
        public string? Id_Order { get; set; }
        public string Item_Name { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }
}
