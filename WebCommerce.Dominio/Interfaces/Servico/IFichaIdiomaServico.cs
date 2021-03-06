﻿using Aula09.Comum.NotificationPattern;
using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IFichaIdiomaServico
    {
        FichaIdioma ListarUm(int CodIdioma, int CodJogador, int CodFicha);

        IEnumerable<FichaIdioma> ListarAtivos();
        Task<List<FichaIdioma>> ListarTodos();

        NotificationResult Salvar(FichaIdioma entidade);
        NotificationResult Excluir(int CodIdioma, int CodJogador, int CodFicha);
    }
}
