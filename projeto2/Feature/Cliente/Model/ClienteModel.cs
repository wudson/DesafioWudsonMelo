using projeto2.Feature.Pessoa.Model;
using System;

namespace projeto2.Feature.Cliente.Model
{
    public class ClienteModel : PessoaModel
    {
        public int IdCliente { get; set; }
        public DateTime DataCadastroCliente { get; set; }
        public DateTime DataEdicaoCliente { get; set; }
    }
}