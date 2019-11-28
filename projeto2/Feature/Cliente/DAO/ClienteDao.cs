using System;
using System.Collections.Generic;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Cliente.Model;
using projeto2.Feature.Pessoa.Dao;

namespace projeto2.Feature.Cliente.Dao
{
    public class ClienteDao
    {
        public bool Cadastrar(ClienteModel cliente, FbCommand cmd)
        {

            cmd.Parameters.Add("@dataCadastro", FbDbType.Date).Value = cliente.DataCadastroCliente;
            cmd.Parameters.Add("@dataEdicao", FbDbType.Date).Value = cliente.DataEdicaoCliente;
            cmd.Parameters.Add("@id_pessoa", FbDbType.Integer).Value = new PessoaDao().Cadastrar(cliente, cmd);

            const string mSql = @"INSERT into CLIENTE (DATA_CADASTRO_CLIENTE, DATA_EDICAO_CLIENTE, ID_PESSOA) 
                                    Values(@dataCadastro, @dataEdicao, @id_pessoa)";
            cmd.CommandText = mSql;

            cmd.ExecuteNonQuery();

            return true;
        }

        public virtual ClienteModel Buscar(int idCliente, FbCommand cmd)
        {
            const string mSql = @"Select c.*, p.* from CLIENTE c
                                INNER JOIN PESSOA as p ON c.ID_PESSOA = p.ID_PESSOA
                                WHERE c.ID_PESSOA = @id";

            cmd.CommandText = mSql;

            cmd.Parameters.Add("@id", FbDbType.Integer).Value = idCliente;

            var dataReader = cmd.ExecuteReader();
            var cliente = new ClienteModel();
            while (dataReader.Read())
            {
                cliente.IdCliente = Convert.ToInt32(dataReader["ID_CLIENTE"]);
                cliente.NomePessoa = dataReader["NOME_PESSOA"].ToString();
                cliente.EmailPessoa = dataReader["EMAIL_PESSOA"].ToString();
                cliente.CpfPessoa = dataReader["CPF_PESSOA"].ToString();
                cliente.RgPessoa = dataReader["RG_PESSOA"].ToString();
                cliente.SexoPessoa = dataReader["SEXO_PESSOA"].ToString();
                cliente.NascimentoPessoa = Convert.ToDateTime(dataReader["DATA_NASCIMENTO_PESSOA"]);
                cliente.DataCadastroCliente = Convert.ToDateTime(dataReader["DATA_CADASTRO_CLIENTE"]);
                cliente.TelefonePessoa = dataReader["TELEFONE_PESSOA"].ToString();
                cliente.CelularPessoa = dataReader["CELULAR_PESSOA"].ToString();
                cliente.EstadoPessoa = dataReader["ESTADO"].ToString();
                cliente.CidadePessoa = dataReader["CIDADE"].ToString();
                cliente.RuaPessoa = dataReader["RUA"].ToString();
                cliente.ComplementoPessoa = dataReader["COMPLEMENTO"].ToString();
                cliente.BairroPessoa = dataReader["BAIRRO"].ToString();
                cliente.CepPessoa = dataReader["CEP"].ToString();
                cliente.NumeroPessoa = Convert.ToInt32(dataReader["NUMERO"]);
                cliente.IdPessoa = Convert.ToInt32(dataReader["ID_PESSOA"]);
            }
            return cliente;
        }

        public virtual IEnumerable<ClienteModel> ListarDados(FiltrosClienteModel filtros, FbCommand cmd)
        {
            var sql = new StringBuilder();
            sql.Append(@"Select c.*, p.* from CLIENTE c
                       INNER JOIN PESSOA as p ON c.ID_PESSOA = p.ID_PESSOA
                       WHERE (1=1)");

            if (!string.IsNullOrWhiteSpace(filtros.NomePessoa)) sql.Append(" and lower(NOME_PESSOA) like lower(@nome)");
            if (!string.IsNullOrWhiteSpace(filtros.CidadePessoa)) sql.Append(" and lower(CIDADE) like lower(@cidade)");
            if (!string.IsNullOrWhiteSpace(filtros.DataInicio) && !string.IsNullOrWhiteSpace(filtros.DataFim)) sql.Append(" and DATA_CADASTRO_CLIENTE between @dataI and @dataF");
            if (!string.IsNullOrWhiteSpace(filtros.DataInicio)) sql.Append(" and DATA_CADASTRO_CLIENTE >= @dataI");
            if (!string.IsNullOrWhiteSpace(filtros.DataFim)) sql.Append(" and DATA_CADASTRO_CLIENTE <= @dataF");

            cmd.CommandText = sql.ToString();
            var listaClientes = new List<ClienteModel>();

            cmd.Parameters.Add("@nome", FbDbType.VarChar).Value = $"{filtros.NomePessoa}%";
            cmd.Parameters.Add("@cidade", FbDbType.VarChar).Value = filtros.CidadePessoa;
            cmd.Parameters.Add("@dataI", FbDbType.Date).Value = filtros.DataInicio;
            cmd.Parameters.Add("@dataF", FbDbType.Date).Value = filtros.DataFim;

            var dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                var cliente = new ClienteModel
                {
                    IdCliente = Convert.ToInt32(dataReader["ID_CLIENTE"]),
                    NomePessoa = dataReader["NOME_PESSOA"].ToString(),
                    EmailPessoa = dataReader["EMAIL_PESSOA"].ToString(),
                    CpfPessoa = dataReader["CPF_PESSOA"].ToString(),
                    RgPessoa = dataReader["RG_PESSOA"].ToString(),
                    SexoPessoa = dataReader["SEXO_PESSOA"].ToString(),
                    NascimentoPessoa = Convert.ToDateTime(dataReader["DATA_NASCIMENTO_PESSOA"]),
                    DataCadastroCliente = Convert.ToDateTime(dataReader["DATA_CADASTRO_CLIENTE"]),
                    DataEdicaoCliente = Convert.ToDateTime(dataReader["DATA_EDICAO_CLIENTE"]),
                    TelefonePessoa = dataReader["TELEFONE_PESSOA"].ToString(),
                    CelularPessoa = dataReader["CELULAR_PESSOA"].ToString(),
                    EstadoPessoa = dataReader["ESTADO"].ToString(),
                    CidadePessoa = dataReader["CIDADE"].ToString(),
                    RuaPessoa = dataReader["RUA"].ToString(),
                    ComplementoPessoa = dataReader["COMPLEMENTO"].ToString(),
                    BairroPessoa = dataReader["BAIRRO"].ToString(),
                    CepPessoa = dataReader["CEP"].ToString(),
                    NumeroPessoa = Convert.ToInt32(dataReader["NUMERO"]),
                    IdPessoa = Convert.ToInt32(dataReader["ID_PESSOA"])
                };

                listaClientes.Add(cliente);
            }
            return listaClientes;
        }

        public virtual bool Excluir(int idPessoa, FbCommand cmd)
        {
            const string mSql = "DELETE from CLIENTE Where ID_PESSOA= @id";

            cmd.CommandText = mSql;

            cmd.Parameters.Add("@id", FbDbType.Integer).Value = idPessoa;
            cmd.ExecuteNonQuery();

            return new PessoaDao().Excluir(idPessoa, cmd);

        }

        public bool Alterar(ClienteModel cliente, FbCommand cmd)
        {
            const string mSql = @"Update CLIENTE set DATA_EDICAO_CLIENTE = @dataEdicao WHERE ID_PESSOA = @id";

            cmd.CommandText = mSql;

            cmd.Parameters.Add("@id", FbDbType.Integer).Value = cliente.IdPessoa;
            cmd.Parameters.Add("@dataEdicao", FbDbType.Date).Value = cliente.DataEdicaoCliente;
            cmd.ExecuteNonQuery();

            return new PessoaDao().Alterar(cliente, cmd);
        }
    }
}