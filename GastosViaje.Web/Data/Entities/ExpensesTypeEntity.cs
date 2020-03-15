using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GastosViaje.Web.Data.Entities
{
    public class ExpensesTypeEntity
    {
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "The {0} cannot exceed {1} characters")]
        [Required(ErrorMessage = "The field {0} is mandatory")]
        public string Name { get; set; }
    }
}
