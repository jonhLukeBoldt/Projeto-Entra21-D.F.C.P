﻿using System;
using DAL;
using BLL.Interfaces;

namespace BLL
{
    public class Cadastrar : ILoginCadastro
    {
        public void Inserir(string nome, string email, string senha, int idade, string profissao)
        {
            ConnectionDatabase.Insert(nome, email, senha, idade, profissao);
        }
        public string ValidarUsuario(string nome)
        {
            return ConnectionDatabase.ValidarUsuarioExistente(nome);
        }
    }
}
