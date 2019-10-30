using System;
using System.Collections.Generic;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Grupo.Model;
using projeto2.Feature.Marca.Model;

namespace projeto2.Feature.Produto.Dao
{
    public class ProdutoDao
    {
        public bool Cadastrar(Produto produto)
        {
            var conn = Conexao.GetInstancia();
            conn.Open();
            const string mSql = @"INSERT into PRODUTO (NOME_PRODUTO, ID_GRUPO, ID_MARCA, TIPO_PRODUTO, 
                                  QUANTIDADE_ESTOQUE_PRODUTO, VALOR_COMPRA_PRODUTO, VALOR_VENDA_PRODUTO, 
                                  FORNECEDOR_PRODUTO) 
                                  Values(@nome, @grupo, @marca, @tipo, @estoque, @compra, @venda, @fornecedor)";

            var cmd = new FbCommand(mSql, conn);
            try
            {
                cmd.Parameters.Add("@nome", FbDbType.VarChar).Value = (produto.NomeProduto).ToUpper();
                cmd.Parameters.Add("@grupo", FbDbType.Integer).Value = produto.GrupoProduto.IdGrupo;
                cmd.Parameters.Add("@marca", FbDbType.Integer).Value = produto.MarcaProduto.IdMarca;
                cmd.Parameters.Add("@tipo", FbDbType.VarChar).Value = produto.TipoProduto;
                cmd.Parameters.Add("@estoque", FbDbType.Integer).Value = produto.QuantidadeEstoqueProduto;
                cmd.Parameters.Add("@compra", FbDbType.Numeric).Value = produto.ValorCompraProduto;
                cmd.Parameters.Add("@venda", FbDbType.Numeric).Value = produto.ValorVendaProduto;
                cmd.Parameters.Add("@fornecedor", FbDbType.Numeric).Value = produto.FornecedorProduto;

                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public Produto Buscar(int idProduto)
        {
            var conn = Conexao.GetInstancia();
            conn.Open();
            const string mSql = "Select p.*, g.GRUPO, m.MARCA from PRODUTO p, GRUPO g, MARCA m where ID_PRODUTO = @id and p.ID_GRUPO = g.ID_GRUPO and p.ID_MARCA = m.ID_MARCA";
            var cmd = new FbCommand(mSql, conn);
            try
            {
                cmd.Parameters.Add("@id", FbDbType.Integer).Value = idProduto;

                var dataReader = cmd.ExecuteReader();
                var produto = new Produto();
                while (dataReader.Read())
                {
                    produto.IdProduto = Convert.ToInt32(dataReader["ID_PRODUTO"]);
                    produto.NomeProduto = dataReader["NOME_PRODUTO"].ToString();
                    produto.FornecedorProduto = dataReader["FORNECEDOR_PRODUTO"].ToString();
                    produto.ValorCompraProduto = Convert.ToDouble(dataReader["VALOR_COMPRA_PRODUTO"]);
                    produto.ValorVendaProduto = Convert.ToDouble(dataReader["VALOR_VENDA_PRODUTO"]);
                    produto.GrupoProduto = new GrupoModel
                    {
                        IdGrupo = Convert.ToInt32(dataReader["ID_GRUPO"]),
                        Grupo = dataReader["GRUPO"].ToString()

                    };
                    produto.MarcaProduto = new MarcaModel()
                    {
                        IdMarca = Convert.ToInt32(dataReader["ID_MARCA"]),
                        Marca = dataReader["MARCA"].ToString()

                    };
                    produto.TipoProduto = dataReader["TIPO_PRODUTO"].ToString();
                    produto.QuantidadeEstoqueProduto = Convert.ToInt32(dataReader["QUANTIDADE_ESTOQUE_PRODUTO"]);
                }
                return produto;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public bool Excluir(int idProduto)
        {
            var conn = Conexao.GetInstancia();
            conn.Open();
            const string mSql = "DELETE from PRODUTO Where ID_PRODUTO= @id";
            var cmd = new FbCommand(mSql, conn);
            try
            {
                cmd.Parameters.Add("@id", FbDbType.Integer).Value = idProduto;
                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public IList<Produto> Listar(Produto filtros)
        {
            var conn = Conexao.GetInstancia();
            conn.Open();
                                 
            var mSql = "Select p.*, m.MARCA, g.GRUPO from PRODUTO p, MARCA m, GRUPO g where p.ID_GRUPO = g.ID_GRUPO and p.ID_MARCA = m.ID_MARCA";

            if (!string.IsNullOrWhiteSpace(filtros.NomeProduto)) mSql += " and lower(NOME_PRODUTO) like lower(@prod)";
            if (!string.IsNullOrWhiteSpace(filtros.GrupoProduto.Grupo)) mSql += " and lower(GRUPO) like lower(@grupo)";
            if (!string.IsNullOrWhiteSpace(filtros.TipoProduto)) mSql += " and lower(TIPO_PRODUTO) like lower(@tipo)";

            var cmd = new FbCommand(mSql, conn);
            try
            {
                cmd.Parameters.Add("@prod", FbDbType.VarChar).Value = $"{filtros.NomeProduto}%";
                cmd.Parameters.Add("@grupo", FbDbType.VarChar).Value = filtros.GrupoProduto.Grupo;
                cmd.Parameters.Add("@tipo", FbDbType.VarChar).Value = filtros.TipoProduto;

                var dataReader = cmd.ExecuteReader();
                var produtos = new List<Produto>();
                while (dataReader.Read())
                {
                    produtos.Add(new Produto
                    {
                        IdProduto = Convert.ToInt32(dataReader["ID_PRODUTO"]),
                        NomeProduto = dataReader["NOME_PRODUTO"].ToString(),
                        FornecedorProduto = dataReader["FORNECEDOR_PRODUTO"].ToString(),
                        ValorCompraProduto = Convert.ToDouble(dataReader["VALOR_COMPRA_PRODUTO"]),
                        ValorVendaProduto = Convert.ToDouble(dataReader["VALOR_VENDA_PRODUTO"]),
                        GrupoProduto = new GrupoModel
                        {
                            IdGrupo = Convert.ToInt32(dataReader["ID_GRUPO"]),
                            Grupo = dataReader["GRUPO"].ToString()

                        },
                        MarcaProduto = new MarcaModel()
                        {
                            IdMarca = Convert.ToInt32(dataReader["ID_MARCA"]),
                            Marca = dataReader["MARCA"].ToString()

                        },
                        TipoProduto = dataReader["TIPO_PRODUTO"].ToString(),
                        QuantidadeEstoqueProduto = Convert.ToInt32(dataReader["QUANTIDADE_ESTOQUE_PRODUTO"])
                    });
                }
                return produtos;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public bool Alterar(Produto produto)
        {
            var conn = Conexao.GetInstancia();
            conn.Open();
            const string mSql = @"Update PRODUTO set NOME_PRODUTO = @nome, ID_GRUPO = @grupo, 
                                    ID_MARCA = @marca, TIPO_PRODUTO = @tipo, QUANTIDADE_ESTOQUE_PRODUTO = @estoque, 
                                    VALOR_COMPRA_PRODUTO = @compra, VALOR_VENDA_PRODUTO = @venda, 
                                    FORNECEDOR_PRODUTO = @fornecedor WHERE ID_PRODUTO = @id";

            var cmd = new FbCommand(mSql, conn);
            try
            {
                cmd.Parameters.Add("@nome", FbDbType.VarChar).Value = produto.NomeProduto;
                cmd.Parameters.Add("@grupo", FbDbType.Integer).Value = produto.GrupoProduto.IdGrupo;
                cmd.Parameters.Add("@marca", FbDbType.Integer).Value = produto.MarcaProduto.IdMarca;
                cmd.Parameters.Add("@tipo", FbDbType.VarChar).Value = produto.TipoProduto;
                cmd.Parameters.Add("@estoque", FbDbType.Integer).Value = produto.QuantidadeEstoqueProduto;
                cmd.Parameters.Add("@compra", FbDbType.Numeric).Value = produto.ValorCompraProduto;
                cmd.Parameters.Add("@venda", FbDbType.Numeric).Value = produto.ValorVendaProduto;
                cmd.Parameters.Add("@fornecedor", FbDbType.Numeric).Value = produto.FornecedorProduto;
                cmd.Parameters.Add("@id", FbDbType.Integer).Value = produto.IdProduto;

                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
    }
}