﻿using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Pessoa.Model;

namespace projeto2.Feature.Pessoa.Dao
{
    public class PessoaDao
    {
        public int Cadastrar(PessoaModel pessoa, FbCommand cmd)
        {
            const string mSql = @"INSERT into PESSOA (NOME_PESSOA, EMAIL_PESSOA, CPF_PESSOA, RG_PESSOA, SEXO_PESSOA, 
                                DATA_NASCIMENTO_PESSOA, TELEFONE_PESSOA, CELULAR_PESSOA, ESTADO, CIDADE, CEP, RUA, COMPLEMENTO, 
                                NUMERO, BAIRRO) 
                                Values(@nome, @email, @cpf, @rg, @sexo, @nascimento, @tel, @cel, @estado, @cidade, @cep, @rua, @complemento,
                                @numero, @bairro) RETURNING Id_PESSOA";
            cmd.CommandText = mSql;

            cmd = AdicionarParametrosDeCadastro(pessoa, cmd);

            var idpessoa = int.Parse(cmd.ExecuteScalar().ToString());
            return idpessoa;
        }

        public FbCommand AdicionarParametrosDeCadastro(PessoaModel pessoa, FbCommand cmd)
        {
            cmd.Parameters.Add("@nome", FbDbType.VarChar).Value = pessoa.NomePessoa;
            cmd.Parameters.Add("@email", FbDbType.VarChar).Value = pessoa.EmailPessoa;
            cmd.Parameters.Add("@cpf", FbDbType.VarChar).Value = pessoa.CpfPessoa;
            cmd.Parameters.Add("@rg", FbDbType.VarChar).Value = pessoa.RgPessoa;
            cmd.Parameters.Add("@sexo", FbDbType.Char).Value = pessoa.SexoPessoa;
            cmd.Parameters.Add("@nascimento", FbDbType.Date).Value = pessoa.NascimentoPessoa;
            cmd.Parameters.Add("@tel", FbDbType.VarChar).Value = pessoa.TelefonePessoa;
            cmd.Parameters.Add("@cel", FbDbType.VarChar).Value = pessoa.CelularPessoa;
            cmd.Parameters.Add("@estado", FbDbType.VarChar).Value = pessoa.EstadoPessoa;
            cmd.Parameters.Add("@cidade", FbDbType.VarChar).Value = pessoa.CidadePessoa;
            cmd.Parameters.Add("@cep", FbDbType.VarChar).Value = pessoa.CepPessoa;
            cmd.Parameters.Add("@rua", FbDbType.VarChar).Value = pessoa.RuaPessoa;
            cmd.Parameters.Add("@complemento", FbDbType.VarChar).Value = pessoa.ComplementoPessoa;
            cmd.Parameters.Add("@numero", FbDbType.Integer).Value = pessoa.NumeroPessoa;
            cmd.Parameters.Add("@bairro", FbDbType.VarChar).Value = pessoa.BairroPessoa;
            return cmd;
        }

        public bool Excluir(int idPessoa, FbCommand cmd)
        {
            cmd.Parameters["@id"].Value = idPessoa;
            const string mSql = "DELETE from PESSOA Where ID_PESSOA = @id";
            cmd.CommandText = mSql;

            cmd.ExecuteNonQuery();

            return true;
        }

        public bool Alterar(PessoaModel pessoa, FbCommand cmd)
        {
            const string mSql = @"Update PESSOA set NOME_PESSOA = @nome, EMAIL_PESSOA = @email, 
                                    CPF_PESSOA = @cpf, RG_PESSOA = @rg, SEXO_PESSOA = @sexo, DATA_NASCIMENTO_PESSOA = @nascimento,
                                    TELEFONE_PESSOA = @tel, CELULAR_PESSOA = @cel, ESTADO = @estado, CIDADE = @cidade, 
                                    CEP = @cep, RUA = @rua, COMPLEMENTO = @complemento, NUMERO = @numero,
                                    BAIRRO = @bairro
                                    WHERE ID_PESSOA = @id";
            cmd.CommandText = mSql;

            cmd.Parameters["@id"].Value = pessoa.IdPessoa;
            cmd = AdicionarParametrosDeEdicao(pessoa, cmd);

            cmd.ExecuteNonQuery();

            return true;
        }

        public FbCommand AdicionarParametrosDeEdicao(PessoaModel pessoa, FbCommand cmd)
        {
            cmd.Parameters.Add("@nome", FbDbType.VarChar).Value = pessoa.NomePessoa;
            cmd.Parameters.Add("@email", FbDbType.VarChar).Value = pessoa.EmailPessoa;
            cmd.Parameters.Add("@cpf", FbDbType.VarChar).Value = pessoa.CpfPessoa;
            cmd.Parameters.Add("@rg", FbDbType.VarChar).Value = pessoa.RgPessoa;
            cmd.Parameters.Add("@sexo", FbDbType.Char).Value = pessoa.SexoPessoa;
            cmd.Parameters.Add("@nascimento", FbDbType.Date).Value = pessoa.NascimentoPessoa;
            cmd.Parameters.Add("@tel", FbDbType.VarChar).Value = pessoa.TelefonePessoa;
            cmd.Parameters.Add("@cel", FbDbType.VarChar).Value = pessoa.CelularPessoa;
            cmd.Parameters.Add("@estado", FbDbType.VarChar).Value = pessoa.EstadoPessoa;
            cmd.Parameters.Add("@cidade", FbDbType.VarChar).Value = pessoa.CidadePessoa;
            cmd.Parameters.Add("@cep", FbDbType.VarChar).Value = pessoa.CepPessoa;
            cmd.Parameters.Add("@rua", FbDbType.VarChar).Value = pessoa.RuaPessoa;
            cmd.Parameters.Add("@complemento", FbDbType.VarChar).Value = pessoa.ComplementoPessoa;
            cmd.Parameters.Add("@numero", FbDbType.Integer).Value = pessoa.NumeroPessoa;
            cmd.Parameters.Add("@bairro", FbDbType.VarChar).Value = pessoa.BairroPessoa;
            return cmd;
        }
    }
}
