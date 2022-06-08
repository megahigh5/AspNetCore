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
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Column(TypeName = "nvarchar(30)")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Description is required")]
        [Column(TypeName = "nvarchar(30)")]
        public string Description { get; set; }

    }
}
