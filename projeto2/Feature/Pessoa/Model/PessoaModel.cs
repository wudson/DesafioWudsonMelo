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
        public string CpfPessoa { get; set; }
        public string RgPessoa { get; set; }
    }
}