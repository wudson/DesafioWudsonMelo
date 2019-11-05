using System;

namespace projeto2.Feature.Promocao.Model
{
    public class PromocaoModel
    {
        public string NomePromocao { get; set; }
        public string StatusPromocao { get; set; }
        public string TipoPromocao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
