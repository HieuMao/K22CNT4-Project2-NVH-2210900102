using System;
using System.Collections.Generic;
using System.Linq;

        namespace K22CNT4_TTCD_Nguyễn_Văn_Hiếu_2210900102.Models
    {
        public class CartItem
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal ProductPrice { get; set; }
            public int Quantity { get; set; }
            public string ProductImage { get; set; }
        }
    }
