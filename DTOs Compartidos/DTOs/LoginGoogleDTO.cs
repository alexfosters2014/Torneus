using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs_Compartidos.DTOs
{
    public class LoginGoogleDTO
    {
        public string TokenGoogle { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
    }
}
