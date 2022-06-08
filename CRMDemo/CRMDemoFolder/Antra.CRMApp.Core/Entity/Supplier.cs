using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Antra.CRMApp.Core.Entity
{
    public class Supplier
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Company name is required")]
        [Column(TypeName ="nvarchar(40)")]
        public string CompanyName { get; set; }


        [Required(ErrorMessage = "Contact name is required")]
        [Column(TypeName = "nvarchar(30)")]
        public string ContactName { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [Column(TypeName = "nvarchar(60)")]
        public string Address { get; set; }


        [Required(ErrorMessage = "City is required")]
        [Column(TypeName = "nvarchar(15)")]
        public string City { get; set; }

        public int RegionId { get; set; }

        [Required(ErrorMessage = "Postal code is required")]
        [Column(TypeName = "nvarchar(10)")]
        public string PostalCode { get; set; }


        [Required(ErrorMessage = "Country is required")]
        [Column(TypeName = "nvarchar(15)")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [Column(TypeName = "nvarchar(24)")]
        public string Phone { get; set; }


    }
}
