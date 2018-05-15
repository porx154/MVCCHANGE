using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLINICAMVC.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string PasswordUsuario { get; set; }
        public bool EstadoUsuario { get; set; }
        public Roles IdRol { get; set; }

    }
}