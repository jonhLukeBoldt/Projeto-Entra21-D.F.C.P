﻿using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Metadata;

namespace BLL.Interfaces
{
    interface ILoginCadastro
    {
        public void Inserir(Usuario usuario)
        {
            ConnectionDatabase.Insert(usuario);
        }
        public string ValidarUsuario(Usuario usuario)
        {
            return ConnectionDatabase.ValidarUsuarioExistente(usuario);
        }
    }
}
