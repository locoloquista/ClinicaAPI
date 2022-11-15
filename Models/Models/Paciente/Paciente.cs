using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Paciente
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public string NombrePaciente { get; set; }
        public string DireccionPaciente { get; set; }
        public int Telefono { get; set; }
        public int Edad { get; set; }
        public byte Activo { get; set; }
    }
}
