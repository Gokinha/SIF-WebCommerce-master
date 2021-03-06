﻿using Aula09.Comum.NotificationPattern;
using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IIdiomaServico
    {
        Idioma ListarUm(int CodIdioma);

        IEnumerable<Idioma> ListarAtivos();
        Task<List<Idioma>> ListarTodos();

        NotificationResult Salvar(Idioma entidade);
        NotificationResult Excluir(int CodIdioma);
    }
}
