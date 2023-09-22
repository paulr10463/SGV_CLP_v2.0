using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes
{
    public class Usuario
    {
        public string? cc_Usuario { get; set; }
        public string? userName { get; set; }
        public string? contrasenia { get; set; }
        public string? primer_Nombre { get; set; }
        public string? segundo_Nombre { get; set; }
        public string? primer_Apellido { get; set; }
        public string? segundo_Apellido { get; set; }
        public string? cargo { get; set; }

        public Usuario(string? cc_Usuario, string? userName, string? contrasenia, string? primer_Nombre, string? primer_Apellido, string? cargo)
        {
            this.cc_Usuario = cc_Usuario;
            this.userName = userName;
            this.contrasenia = contrasenia;
            this.primer_Nombre = primer_Nombre;
            this.primer_Apellido = primer_Apellido;
            this.cargo = cargo;
        }

        public Usuario() { }

    }
}
