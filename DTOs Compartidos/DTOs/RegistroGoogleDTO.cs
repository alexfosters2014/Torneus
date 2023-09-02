using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs_Compartidos.DTOs
{
    public class RegistroGoogleDTO
    {
        [Required(ErrorMessage = "Obligatorio")]
        public string Rol { get; set; }
        public string TokenGoogle { get; set; }
    }
}
