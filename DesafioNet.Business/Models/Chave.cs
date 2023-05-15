using System;
using static DesafioNet.Business.Models.Enumerado;

namespace DesafioNet.Business.Models
{
    public class Chave : Entity
    {
        public Guid Id { get; set; }
        public ETipoChave TipoChave { get; set; }
        public string Descricao { get; set; }
    }
}
