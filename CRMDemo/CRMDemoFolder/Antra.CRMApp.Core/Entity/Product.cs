using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Antra.CRMApp.Core.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        public int SupplierId { get; set; }

        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Quantity per unit is required")]
        [Column(TypeName = "nvarchar(20)")]
        public string QuantityPerUnit { get; set; }

        [Required(ErrorMessage = "Unit price is required")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public int UnitsOnOrder { get; set; }

        public int ReorderLevel { get; set; }

        public bool Discountinued { get; set; }
    }
}
