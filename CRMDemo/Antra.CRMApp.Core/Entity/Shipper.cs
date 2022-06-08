using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Antra.CRMApp.Core.Entity
{
    public class Shipper
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Company name is required")]
        [Column(TypeName = "nvarchar(40)")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [Column(TypeName = "nvarchar(24)")]
        public string Phone { get; set; }

  
    }
}
