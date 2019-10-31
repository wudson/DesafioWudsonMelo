﻿using System;
using System.Collections.Generic;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Cliente.Model;
using projeto2.Feature.Pessoa.Dao;

namespace projeto2.Feature.Cliente.Dao
{
    public class ClienteDao
    {
        public bool Cadastrar(ClienteModel cliente)
        {
            var conn = Conexao.GetInstancia();
            conn.Open();
            var transaction = conn.BeginTransaction();
            var cmd = new FbCommand { Transaction = transaction, Connection = conn };
            try
            {
                cmd.Parameters.Add("@dataCadastro", FbDbType.Date).Value = cliente.DataCadastroCliente;
                cmd.Parameters.Add("@id_pessoa", FbDbType.Integer).Value = new PessoaDao().Cadastrar(cliente, cmd);

                const string mSql = @"INSERT into CLIENTE (DATA_CADASTRO_CLIENTE, ID_PESSOA) 
                                    Values(@dataCadastro, @id_pessoa)";
                cmd.CommandText = mSql;

                cmd.ExecuteNonQuery();

                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public ClienteModel Buscar(int idCliente)
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
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public IEnumerable<ClienteModel> BuscarComFiltros(FiltrosClienteModel filtros)
        {
            var conn = Conexao.GetInstancia();
            conn.Open();
            var mSql = "Select c.*, p.* from CLIENTE c, PESSOA p where c.ID_PESSOA = p.ID_PESSOA";

            if (!string.IsNullOrWhiteSpace(filtros.NomePessoa)) mSql += " and lower(NOME_PESSOA) like lower(@nome)";
            if (!string.IsNullOrWhiteSpace(filtros.CidadePessoa)) mSql += " and lower(CIDADE) like lower(@cidade)";
            if (!string.IsNullOrWhiteSpace(filtros.DataInicio) && !string.IsNullOrWhiteSpace(filtros.DataFim)) mSql += " and DATA_CADASTRO_CLIENTE between @dataI and @dataF";
            if (!string.IsNullOrWhiteSpace(filtros.DataInicio)) mSql += " and DATA_CADASTRO_CLIENTE >= @dataI";
            if (!string.IsNullOrWhiteSpace(filtros.DataFim)) mSql += " and DATA_CADASTRO_CLIENTE <= @dataF";

            var cmd = new FbCommand(mSql, conn);
            var listaClientes = new List<ClienteModel>();
            try
            {
                cmd.Parameters.Add("@nome", FbDbType.VarChar).Value = $"{filtros.NomePessoa}%";
                cmd.Parameters.Add("@cidade", FbDbType.VarChar).Value = filtros.CidadePessoa;
                cmd.Parameters.Add("@dataI", FbDbType.Date).Value = filtros.DataInicio;
                cmd.Parameters.Add("@dataF", FbDbType.Date).Value = filtros.DataFim;

                var dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    var cliente = new ClienteModel()
                    {
                        IdCliente = Convert.ToInt32(dataReader["ID_CLIENTE"]),
                        NomePessoa = dataReader["NOME_PESSOA"].ToString(),
                        EmailPessoa = dataReader["EMAIL_PESSOA"].ToString(),
                        CpfPessoa = dataReader["CPF_PESSOA"].ToString(),
                        RgPessoa = dataReader["RG_PESSOA"].ToString(),
                        SexoPessoa = dataReader["SEXO_PESSOA"].ToString(),
                        NascimentoPessoa = Convert.ToDateTime(dataReader["DATA_NASCIMENTO_PESSOA"]),
                        DataCadastroCliente = Convert.ToDateTime(dataReader["DATA_CADASTRO_CLIENTE"]),
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
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

            return listaClientes;
        }

        public bool Excluir(int idPessoa)
        {
            var conn = Conexao.GetInstancia();
            conn.Open();
            const string mSql = "DELETE from CLIENTE Where ID_PESSOA= @id";
            var transaction = conn.BeginTransaction();
            var cmd = new FbCommand(mSql, conn, transaction);
            try
            {
                cmd.Parameters.Add("@id", FbDbType.Integer).Value = idPessoa;
                cmd.ExecuteNonQuery();

                return new PessoaDao().Excluir(idPessoa, cmd);
            }
            finally
            {
                conn.Close();
            }
        }

        public IList<ClienteModel> Listar()
        {
            var conn = Conexao.GetInstancia();
            conn.Open();
            const string mSql = @"Select p.*, c.*
                                from  PESSOA p, CLIENTE c where c.ID_PESSOA = p.ID_PESSOA";
            var cmd = new FbCommand(mSql, conn);
            try
            {
                var dataReader = cmd.ExecuteReader();
                var clientes = new List<ClienteModel>();
                while (dataReader.Read())
                {
                    clientes.Add(new ClienteModel()
                    {
                        IdCliente = Convert.ToInt32(dataReader["ID_CLIENTE"]),
                        NomePessoa = dataReader["NOME_PESSOA"].ToString(),
                        EmailPessoa = dataReader["EMAIL_PESSOA"].ToString(),
                        CpfPessoa = dataReader["CPF_PESSOA"].ToString(),
                        RgPessoa = dataReader["RG_PESSOA"].ToString(),
                        SexoPessoa = dataReader["SEXO_PESSOA"].ToString(),
                        NascimentoPessoa = Convert.ToDateTime(dataReader["DATA_NASCIMENTO_PESSOA"]),
                        DataCadastroCliente = Convert.ToDateTime(dataReader["DATA_CADASTRO_CLIENTE"]),
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
                    });
                }
                return clientes;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public bool Alterar(ClienteModel cliente)
        {
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
                    transaction.Commit();

                return true;
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
    }
}