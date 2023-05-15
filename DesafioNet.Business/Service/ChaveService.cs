using DesafioNet.Business.Interface;
using DesafioNet.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioNet.Business.Service
{
    public class ChaveService 
    {
        private readonly IRepository<Chave> _chaveRepository;


        public ChaveService(IRepository<Chave> chaveRepository)
        {
            _chaveRepository = chaveRepository;
        }

        public void CadastrarChave(Chave chave)
        {
            _chaveRepository.Adicionar(chave);
        }
    }
}
