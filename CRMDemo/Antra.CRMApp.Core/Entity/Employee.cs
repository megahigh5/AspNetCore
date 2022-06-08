using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Antra.CRMApp.Core.Entity
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "FirstName is required")]
        [Column(TypeName = "nvarchar(10)")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "LastName is required")]
        [Column(TypeName = "nvarchar(20)")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Title is required")]
        [Column(TypeName = "nvarchar(30)")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Title of COurtssey is required")]
        [Column(TypeName = "nvarchar(25)")]
        public string TitleOfCourtssy { get; set; }


        public DateTime BirthDate { get; set; }

        public DateTime HireDate { get; set; }


        [Required(ErrorMessage = "Address is required")]
        [Column(TypeName = "nvarchar(60)")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        [Column(TypeName = "nvarchar(15)")]
        public string City { get; set; }

        public int RegionId { get; set; }

        [Required(ErrorMessage = "PostalCode is required")]
        [Column(TypeName = "nvarchar(10)")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [Column(TypeName = "nvarchar(15)")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [Column(TypeName = "nvarchar(24)")]
        public string Phone { get; set; }

        public int ReportsTo { get; set; }

        [Required(ErrorMessage = "PhotoPath is required")]
        [Column(TypeName = "nvarchar(255)")]
        public string PhotoPath { get; set; }


    }
}
