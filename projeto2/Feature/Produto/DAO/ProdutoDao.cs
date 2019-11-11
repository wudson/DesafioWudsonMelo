using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Grupo.Model;
using projeto2.Feature.Marca.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace projeto2.Feature.Produto.Dao
{
    public class ProdutoDao
    {
        public bool Cadastrar(Produto produto, FbCommand cmd)
        {
            const string mSql = @"INSERT into PRODUTO (NOME_PRODUTO, ID_GRUPO, ID_MARCA, TIPO_PRODUTO, 
                                  QUANTIDADE_ESTOQUE_PRODUTO, VALOR_COMPRA_PRODUTO, VALOR_VENDA_PRODUTO, 
                                  FORNECEDOR_PRODUTO, CODIGO_DE_BARRA_PRODUTO) 
                                  Values(@nome, @grupo, @marca, @tipo, @estoque, @compra, @venda, @fornecedor, @codigo)";

            cmd.CommandText = mSql;

            cmd.Parameters.Add("@nome", FbDbType.VarChar).Value = produto.NomeProduto;
            cmd.Parameters.Add("@grupo", FbDbType.Integer).Value = produto.GrupoProduto.IdGrupo;
            cmd.Parameters.Add("@marca", FbDbType.Integer).Value = produto.MarcaProduto.IdMarca;
            cmd.Parameters.Add("@tipo", FbDbType.VarChar).Value = produto.TipoProduto;
            cmd.Parameters.Add("@estoque", FbDbType.Integer).Value = produto.QuantidadeEstoqueProduto;
            cmd.Parameters.Add("@compra", FbDbType.Numeric).Value = produto.ValorCompraProduto;
            cmd.Parameters.Add("@venda", FbDbType.Numeric).Value = produto.ValorVendaProduto;
            cmd.Parameters.Add("@fornecedor", FbDbType.VarChar).Value = produto.FornecedorProduto;
            cmd.Parameters.Add("@codigo", FbDbType.VarChar).Value = produto.CodigoDeBarras;

            cmd.ExecuteNonQuery();

            return true;
        }

        public Produto Buscar(int idProduto, FbCommand cmd)
        {
            const string mSql = @"SELECT p.*, g.Grupo, m.Marca FROM Produto p
                                INNER JOIN Grupo AS g ON p.Id_Grupo = g.Id_Grupo
                                INNER JOIN Marca AS m ON p.Id_Marca = m.Id_Marca
                                WHERE p.Id_Produto = @id";

            cmd.CommandText = mSql;

            cmd.Parameters.Add("@id", FbDbType.Integer).Value = idProduto;

            var dataReader = cmd.ExecuteReader();
            var produto = new Produto();
            while (dataReader.Read())
            {
                produto.IdProduto = Convert.ToInt32(dataReader["ID_PRODUTO"]);
                produto.NomeProduto = dataReader["NOME_PRODUTO"].ToString();
                produto.FornecedorProduto = dataReader["FORNECEDOR_PRODUTO"].ToString();
                produto.CodigoDeBarras = dataReader["CODIGO_DE_BARRA_PRODUTO"].ToString();
                produto.ValorCompraProduto = Convert.ToDouble(dataReader["VALOR_COMPRA_PRODUTO"]);
                produto.ValorVendaProduto = Convert.ToDouble(dataReader["VALOR_VENDA_PRODUTO"]);
                produto.GrupoProduto = new GrupoModel
                {
                    IdGrupo = Convert.ToInt32(dataReader["ID_GRUPO"]),
                    Grupo = dataReader["GRUPO"].ToString()

                };
                produto.MarcaProduto = new MarcaModel
                {
                    IdMarca = Convert.ToInt32(dataReader["ID_MARCA"]),
                    Marca = dataReader["MARCA"].ToString()

                };
                produto.TipoProduto = dataReader["TIPO_PRODUTO"].ToString();
                produto.QuantidadeEstoqueProduto = Convert.ToInt32(dataReader["QUANTIDADE_ESTOQUE_PRODUTO"]);
            }
            return produto;
        }

        public bool Excluir(int idProduto, FbCommand cmd)
        {
            const string mSql = "DELETE from PRODUTO Where ID_PRODUTO= @id";
            cmd.CommandText = mSql;

            cmd.Parameters.Add("@id", FbDbType.Integer).Value = idProduto;
            cmd.ExecuteNonQuery();

            return true;
        }

        public IList<Produto> Listar(Produto filtros, FbCommand cmd)
        {
            var sql = new StringBuilder();
            sql.Append(@"Select p.*, m.MARCA, g.GRUPO from PRODUTO p 
                       INNER JOIN Grupo AS g ON p.Id_Grupo = g.Id_Grupo 
                       INNER JOIN Marca AS m ON p.Id_Marca = m.Id_Marca
                       WHERE (1=1)");

            if (!string.IsNullOrWhiteSpace(filtros.NomeProduto))
                sql.Append(" and lower(NOME_PRODUTO) like lower(@prod)");

            if (!string.IsNullOrWhiteSpace(filtros.CodigoDeBarras))
                sql.Append(" and CODIGO_DE_BARRA_PRODUTO like @codigo");

            if (!string.IsNullOrWhiteSpace(filtros.GrupoProduto.Grupo))
                sql.Append(" and lower(GRUPO) like lower(@grupo)");

            if (!string.IsNullOrWhiteSpace(filtros.TipoProduto))
                sql.Append(" and lower(TIPO_PRODUTO) like lower(@tipo)");

            cmd.CommandText = sql.ToString();

            cmd.Parameters.Add("@prod", FbDbType.VarChar).Value = $"{filtros.NomeProduto}%";
            cmd.Parameters.Add("@codigo", FbDbType.VarChar).Value = $"{filtros.CodigoDeBarras}%";
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
                    CodigoDeBarras = dataReader["CODIGO_DE_BARRA_PRODUTO"].ToString(),
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

        public bool Alterar(Produto produto, FbCommand cmd)
        {

            const string mSql = @"Update PRODUTO set NOME_PRODUTO = @nome, ID_GRUPO = @grupo, 
                                    ID_MARCA = @marca, TIPO_PRODUTO = @tipo, QUANTIDADE_ESTOQUE_PRODUTO = @estoque, 
                                    VALOR_COMPRA_PRODUTO = @compra, VALOR_VENDA_PRODUTO = @venda, 
                                    FORNECEDOR_PRODUTO = @fornecedor, CODIGO_DE_BARRA_PRODUTO = @codigo 
                                    WHERE ID_PRODUTO = @id";

            cmd.CommandText = mSql;

            cmd.Parameters.Add("@nome", FbDbType.VarChar).Value = produto.NomeProduto;
            cmd.Parameters.Add("@grupo", FbDbType.Integer).Value = produto.GrupoProduto.IdGrupo;
            cmd.Parameters.Add("@marca", FbDbType.Integer).Value = produto.MarcaProduto.IdMarca;
            cmd.Parameters.Add("@tipo", FbDbType.VarChar).Value = produto.TipoProduto;
            cmd.Parameters.Add("@estoque", FbDbType.Integer).Value = produto.QuantidadeEstoqueProduto;
            cmd.Parameters.Add("@compra", FbDbType.Numeric).Value = produto.ValorCompraProduto;
            cmd.Parameters.Add("@venda", FbDbType.Numeric).Value = produto.ValorVendaProduto;
            cmd.Parameters.Add("@fornecedor", FbDbType.VarChar).Value = produto.FornecedorProduto;
            cmd.Parameters.Add("@codigo", FbDbType.VarChar).Value = produto.CodigoDeBarras;
            cmd.Parameters.Add("@id", FbDbType.Integer).Value = produto.IdProduto;

            cmd.ExecuteNonQuery();
            return true;
        }
    }
}