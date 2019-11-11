using System;
using System.Collections.Generic;

namespace projeto2.Feature.Promocao.Model
{
    public class PromocaoModel
    {
        public int IdPromocao { get; set; }
        public string NomePromocao { get; set; }
        public string StatusPromocao { get; set; }
        public string TipoPromocao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public List<Produto.Produto> Produtos { get; set; }
    }
}
