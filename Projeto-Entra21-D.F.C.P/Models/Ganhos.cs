﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Entra21_DFCP.Models
{
    public class Ganhos
    {
        public int Id { get; set; }
        public string Motivo { get; set; }
        public double Valor { get; set; }
        public DateTime data { get; set; }
        public Usuario Usuario { get; set; }
        public int IdUsuario { get; set; }
    }
}
