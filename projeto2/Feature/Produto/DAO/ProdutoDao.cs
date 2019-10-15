using System;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Interfaces;

namespace projeto2.Feature.Produto.DAO
{
    public class ProdutoDao : ICrudDao
    {
        public bool Cadastrar(Produto produto)
        {
            var conn = Conexao.GetInstancia();
            try
            {
                conn.Open();
                const string mSql = @"INSERT into PRODUTO (NOME_PRODUTO, GRUPO_PRODUTO, MARCA_PRODUTO, 
                                    QUANTIDADE_ESTOQUE_PRODUTO, VALOR_COMPRA_PRODUTO, VALOR_VENDA_PRODUTO, FORNECEDOR_PRODUTO) 
                                    Values(@nome, @grupo, @marca, @estoque, @compra, @venda, @fornecedor)";

                var cmd = new FbCommand(mSql, conn);
                cmd.Parameters.Add("@nome", FbDbType.VarChar).Value = produto.NomeProduto;
                cmd.Parameters.Add("@grupo", FbDbType.VarChar).Value = produto.GrupoProduto;
                cmd.Parameters.Add("@marca", FbDbType.VarChar).Value = produto.MarcaProduto;
                cmd.Parameters.Add("@estoque", FbDbType.Integer).Value = produto.QuantidadeEstoqueProduto;
                cmd.Parameters.Add("@compra", FbDbType.Numeric).Value = produto.ValorCompraProduto;
                cmd.Parameters.Add("@venda", FbDbType.Numeric).Value = produto.ValorVendaProduto;
                cmd.Parameters.Add("@fornecedor", FbDbType.Numeric).Value = produto.FornecedorProduto;

                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                conn.Close();
            }
        }

        public Produto Buscar(int idProduto)
        {
            var conn = Conexao.GetInstancia();
            try
            {
                conn.Open();
                const string mSql = "Select * from PRODUTO where ID_PRODUTO = @id";

                var cmd = new FbCommand(mSql, conn);
                cmd.Parameters.Add("@id", FbDbType.Integer).Value = idProduto;

                var dataReader = cmd.ExecuteReader();
                var produto = new Produto();
                while (dataReader.Read())
                {
                    produto.IdProduto = Convert.ToInt32(dataReader[0]);
                    produto.NomeProduto = dataReader[1].ToString();
                    produto.FornecedorProduto = dataReader[2].ToString();
                    produto.ValorCompraProduto = Convert.ToDouble(dataReader[3]);
                    produto.ValorVendaProduto = Convert.ToDouble(dataReader[4]);
                    produto.GrupoProduto = dataReader[5].ToString();
                    produto.MarcaProduto = dataReader[6].ToString();
                    produto.QuantidadeEstoqueProduto = Convert.ToInt32(dataReader[7]);
                }
                return produto;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Excluir(int idProduto)
        {
            var conn = Conexao.GetInstancia();
            try
            {
                conn.Open();
                const string mSql = "DELETE from PRODUTO Where ID_PRODUTO= @id";
                var cmd = new FbCommand(mSql, conn);
                cmd.Parameters.Add("@id", FbDbType.Integer).Value = idProduto;
                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable Listar()
        {
            var conn = Conexao.GetInstancia();
            try
            {
                conn.Open();
                const string mSql = "Select * from PRODUTO";
                var cmd = new FbCommand(mSql, conn);
                var dataAdapter = new FbDataAdapter(cmd);
                var dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Alterar(Produto produto)
        {
            var conn = Conexao.GetInstancia();
            try
            {
                conn.Open();
                const string mSql = @"Update PRODUTO set NOME_PRODUTO = @nome, GRUPO_PRODUTO = @grupo, MARCA_PRODUTO = @marca, QUANTIDADE_ESTOQUE_PRODUTO = @estoque, VALOR_COMPRA_PRODUTO = @compra, VALOR_VENDA_PRODUTO = @venda, FORNECEDOR_PRODUTO = @fornecedor WHERE ID_PRODUTO = @id";

                var cmd = new FbCommand(mSql, conn);
                cmd.Parameters.Add("@nome", FbDbType.VarChar).Value = produto.NomeProduto;
                cmd.Parameters.Add("@grupo", FbDbType.VarChar).Value = produto.GrupoProduto;
                cmd.Parameters.Add("@marca", FbDbType.VarChar).Value = produto.MarcaProduto;
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
                conn.Close();
            }
        }
    }
}