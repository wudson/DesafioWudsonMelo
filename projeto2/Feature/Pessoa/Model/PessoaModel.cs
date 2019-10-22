using System;

namespace projeto2.Feature.Pessoa.Model
{
    public abstract class PessoaModel
    {
        public int IdPessoa { get; set; }
        public string NomePessoa { get; set; }
        public DateTime NascimentoPessoa { get; set; }
        public string SexoPessoa { get; set; }
        public string EmailPessoa { get; set; }
        public string TelefonePessoa { get; set; }
        public string CelularPessoa { get; set; }
        public string CpfPessoa { get; set; }
        public string RgPessoa { get; set; }
        public string EstadoPessoa { get; set; }
        public string CidadePessoa { get; set; }
        public string CepPessoa { get; set; }
        public string RuaPessoa { get; set; }
        public string BairroPessoa { get; set; }
        public string ComplementoPessoa { get; set; }
        public int NumeroPessoa { get; set; }
    }
}