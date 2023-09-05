using Negocio.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs_Compartidos.Models
{
    public class PrimerSegundoPuestoModel
    {
        public EquipoDTO Ganador { get; set; }
        public EquipoDTO SegundoPuesto { get; set; }
    }
}
