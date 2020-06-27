using Aula09.Comum.NotificationPattern;
using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Interfaces;

namespace WebCommerce.Servico
{
    public class ArmaduraServico : IArmaduraServico
    {
        private readonly IArmaduraRepositorio _armaduraRepositorio;

        public ArmaduraServico(IArmaduraRepositorio armaduraRepositorio)
        {
            _armaduraRepositorio = armaduraRepositorio;
        }

        public NotificationResult Excluir(int CodArmadura)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ArmaduraServico> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<ArmaduraServico>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public ArmaduraServico ListarUm(int CodArmadura)
        {
            return _armaduraRepositorio.ListarUm(CodArmadura);
        }

        public NotificationResult Salvar(ArmaduraServico entidade)
        {
            throw new NotImplementedException();
        }
    }
}
