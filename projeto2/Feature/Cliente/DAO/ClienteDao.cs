using System;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Cliente.Model;
using projeto2.Feature.Interfaces;
using projeto2.Feature.Pessoa.DAO;

namespace projeto2.Feature.Cliente.DAO
{
    public class ClienteDao : ICrudDao
    {
        public bool Cadastrar(object obj)
        {
            var cliente = (ClienteModel)obj;
            var conn = Conexao.GetInstancia();
            conn.Open();
            var transaction = conn.BeginTransaction();
            var cmd = new FbCommand { Transaction = transaction, Connection = conn };
            try
            {
                cmd.Parameters.Add("@dataCadastro", FbDbType.Date).Value = cliente.DataCadastroCliente;
                cmd.Parameters.Add("@id_pessoa", FbDbType.Integer).Value = new PessoaDao().Cadastrar(cliente, cmd);

                const string mSql = @"INSERT into CLIENTE (DATA_CADASTRO_CLIENTE, ID_PESSOA) Values(@dataCadastro, @id_pessoa)";
                cmd.CommandText = mSql;

                cmd.ExecuteNonQuery();

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public object Buscar(int idCliente)
        {
            var conn = Conexao.GetInstancia();
            conn.Open();
            const string mSql = "Select c.*, p.* from CLIENTE c, PESSOA p where c.ID_PESSOA = @id and c.ID_PESSOA = p.ID_PESSOA";
            var cmd = new FbCommand(mSql, conn);
            try
            {
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
                    cliente.IdPessoa = Convert.ToInt32(dataReader["ID_PESSOA"]);
                }
                return cliente;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public bool Excluir(int idPessoa)
        {
            var conn = Conexao.GetInstancia();
            conn.Open();
            const string mSql = "DELETE from CLIENTE Where ID_PESSOA= @id";
            var transaction = conn.BeginTransaction();
            var cmd = new FbCommand(mSql, conn, transaction);
            cmd.Parameters.Add("@id", FbDbType.Integer).Value = idPessoa;
            cmd.ExecuteNonQuery();

            var excluidoOuNao = new PessoaDao().Excluir(idPessoa, cmd);
            conn.Close();
            return excluidoOuNao;
        }

        public DataTable Listar()
        {
            var conn = Conexao.GetInstancia();
            conn.Open();
            const string mSql = @"Select p.ID_PESSOA as ""Cod."", p.NOME_PESSOA as ""Nome"", p.EMAIL_PESSOA as ""Email"", p.TELEFONE_PESSOA as ""Telefone"", 
                                p.DATA_NASCIMENTO_PESSOA as ""Data de nascimento"", c.DATA_CADASTRO_CLIENTE as ""Data de cadastro""
                                from  PESSOA p, CLIENTE c where c.ID_PESSOA = p.ID_PESSOA";
            var cmd = new FbCommand(mSql, conn);
            try
            {
                var dataAdapter = new FbDataAdapter(cmd);
                var dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataAdapter.Dispose();
                return dataTable;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public bool Alterar(object obj)
        {
            var cliente = (ClienteModel)obj;
            var conn = Conexao.GetInstancia();
            conn.Open();
            const string mSql = @"Update CLIENTE set DATA_CADASTRO_CLIENTE = @dataCadastro WHERE ID_PESSOA = @id";
            var transaction = conn.BeginTransaction();
            var cmd = new FbCommand(mSql, conn, transaction);
            try
            {
                cmd.Parameters.Add("@id", FbDbType.Integer).Value = cliente.IdPessoa;
                cmd.Parameters.Add("@dataCadastro", FbDbType.Date).Value = cliente.DataCadastroCliente;
                cmd.ExecuteNonQuery();

                if (new PessoaDao().Alterar(cliente, cmd))
                {
                    transaction.Commit();
                    return true;
                }
                else
                {
                    transaction.Rollback();
                    return false;
                }

            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
    }
}