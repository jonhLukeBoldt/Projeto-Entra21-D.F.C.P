﻿using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using BLL.Interfaces;
using Metadata;

namespace BLL
{
    public class GanhosBLL : IPaginas
    {
        public List<string> ListaNome(Usuario usuario)
        {
            string tabela = "Ganhos"; string motivo = "Motivo";
            List<string> lt = new List<string>();
            ConnectionDatabase.HistóricoNomes(tabela, motivo, usuario.Nome, out lt);
            return lt;
        }
        public List<double> Listavalor(Usuario usuario)
        {
            string tabela = "Ganhos"; string motivo = "Motivo";
            List<double> lt = new List<double>();
            ConnectionDatabase.HistóricoValores(tabela, motivo, usuario.Nome, out lt);
            return lt;
        }
        public void CadastrarValor(string nome, double valor, string motivo)
        {
            string tabela = "Ganhos";
            ConnectionDatabase.InsertValor(tabela, nome, valor, motivo);
        }
    }
}
