﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FichaAcademia.dominio.Models
{
    public class Administrador
    {
        public int AdministradoresId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

    }
}
