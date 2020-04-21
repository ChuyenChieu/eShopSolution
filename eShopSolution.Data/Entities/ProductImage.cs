using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImagePath { get; set; }
        public string Caption { get; set; } //mo ta image
        public bool IsDefault { get; set; } //chon anh mac dinh hien thi
        public DateTime DateCreated { get; set; }
        public int SortOrder { get; set; } //thu tu
        public long FileSize { get; set; }
        public Product Product { get; set; }
    }
}
