﻿using System;


namespace Metadata
{
    public class ContasPagar
    {
        public int Id { get; set; }
        public string Conta { get; set; }
        public double ValorConta { get; set; }
        public DateTime DataPagar { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}
