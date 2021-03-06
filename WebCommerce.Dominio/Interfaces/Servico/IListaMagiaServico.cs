﻿using Aula09.Comum.NotificationPattern;
using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IListaMagiaServico
    {
        ListaMagia ListarUm(int CodMagia, int CodFicha, int CodJogador);

        IEnumerable<ListaMagia> ListarAtivos();
        Task<List<ListaMagia>> ListarTodos();

        NotificationResult Salvar(ListaMagia entidade);
        NotificationResult Excluir(int CodMagia, int CodFicha, int CodJogador);
    }
}
