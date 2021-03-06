﻿using Aula09.Comum.NotificationPattern;
using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IPericiaServico
    {
        Pericia ListarUm(int CodJogador, int CodFicha);

        IEnumerable<Pericia> ListarAtivos();
        Task<List<Pericia>> ListarTodos();

        NotificationResult Salvar(Pericia entidade);
        NotificationResult Excluir(int CodJogador, int CodFicha);
    }
}
