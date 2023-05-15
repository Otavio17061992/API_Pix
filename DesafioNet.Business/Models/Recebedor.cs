using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioNet.Business.Models
{
    public class Recebedor
    {
        public Guid Id { get; set; }
        public Chave Chave { get; set; }
        public string Nome { get; set; }
        public ICollection<Transacao> Transacoes { get; set; }
    }
}
