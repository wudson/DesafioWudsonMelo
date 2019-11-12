using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Promocao.Model;
using System;
using System.Collections.Generic;
using System.Text;
using projeto2.Feature.Grupo.Model;
using projeto2.Feature.Marca.Model;

namespace projeto2.Feature.Promocao.Dao
{
    public class PromocaoDao
    {
        public bool Cadastrar(PromocaoModel promocao, FbCommand cmd)
        {
            const string mSql = @"INSERT into promocao (NOME_PROMOCAO, TIPO_PROMOCAO, STATUS_PROMOCAO, 
                                DATA_INICIO_PROMOCAO, DATA_FIM_PROMOCAO) 
                                Values(@nome, @tipo, @status, @dataInicio, @dataFim) RETURNING ID_PROMOCAO";

            cmd.CommandText = mSql;

            cmd.Parameters.Add("@nome", FbDbType.VarChar).Value = promocao.NomePromocao;
            cmd.Parameters.Add("@tipo", FbDbType.VarChar).Value = promocao.TipoPromocao;
            cmd.Parameters.Add("@status", FbDbType.VarChar).Value = promocao.StatusPromocao;
            cmd.Parameters.Add("@dataInicio", FbDbType.Date).Value = promocao.DataInicio;
            cmd.Parameters.Add("@dataFim", FbDbType.Date).Value = promocao.DataFim;

            promocao.IdPromocao = int.Parse(cmd.ExecuteScalar().ToString());

            CadastrarProdutosDaPromocao(promocao, cmd);

            return true;
        }

        private static void CadastrarProdutosDaPromocao(PromocaoModel promocao, FbCommand cmd)
        {
            const string mSql = @"INSERT into ITEM_PROMOCAO (ID_PRODUTO, ID_PROMOCAO, VALOR_COM_DESCONTO) 
                                    Values(@produto, @promocao, @desconto)";
            cmd.CommandText = mSql;

            cmd.Parameters.Add("@produto", FbDbType.Integer);
            cmd.Parameters.Add("@promocao", FbDbType.Integer);
            cmd.Parameters.Add("@desconto", FbDbType.Numeric);

            foreach (var produto in promocao.Produtos)
            {
                cmd.Parameters["@produto"].Value = produto.IdProduto;
                cmd.Parameters["@promocao"].Value = promocao.IdPromocao;
                cmd.Parameters["@desconto"].Value = produto.ValorComDesconto;
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<PromocaoModel> Listar(FbCommand cmd)
        {
            var sql = new StringBuilder();
            sql.Append(@"Select * from PROMOCAO");

            cmd.CommandText = sql.ToString();

            var dataReader = cmd.ExecuteReader();
            var promocoes = new List<PromocaoModel>();
            while (dataReader.Read())
            {
                promocoes.Add(new PromocaoModel
                {
                    IdPromocao = Convert.ToInt32(dataReader["ID_PROMOCAO"]),
                    NomePromocao = dataReader["NOME_PROMOCAO"].ToString(),
                    TipoPromocao = dataReader["TIPO_PROMOCAO"].ToString(),
                    StatusPromocao = dataReader["STATUS_PROMOCAO"].ToString(),
                    DataInicio = Convert.ToDateTime(dataReader["DATA_INICIO_PROMOCAO"]),
                    DataFim = Convert.ToDateTime(dataReader["DATA_FIM_PROMOCAO"]),
                    Produtos = BuscarProdutosDaPromocao(Convert.ToInt32(dataReader["ID_PROMOCAO"]), cmd.Connection)
                });
            }

            return promocoes;
        }

        private static List<Produto.Produto> BuscarProdutosDaPromocao(int idPromocao, FbConnection conn)
        {
            

            var sql = new StringBuilder();
            sql.Append(@"Select ip.VALOR_COM_DESCONTO, prod.*, m.*, g.* from PROMOCAO p 
                       INNER JOIN ITEM_PROMOCAO as ip ON p.ID_PROMOCAO = ip.ID_PROMOCAO
                       INNER JOIN PRODUTO as prod ON ip.ID_PRODUTO = prod.ID_PRODUTO 
                       INNER JOIN MARCA as m ON prod.ID_MARCA = m.ID_MARCA
                       INNER JOIN GRUPO as g ON prod.ID_GRUPO = g.ID_GRUPO
                       WHERE ip.ID_PROMOCAO = @idPromocao");

            var cmd = new FbCommand(sql.ToString(), conn);

            cmd.Parameters.Add("@idPromocao", FbDbType.Integer).Value = idPromocao;


            var dataReader = cmd.ExecuteReader();

            var produtos = new List<Produto.Produto>();
            while (dataReader.Read())
            {
                produtos.Add(new Produto.Produto
                {
                    IdProduto = Convert.ToInt32(dataReader["ID_PRODUTO"]),
                    NomeProduto = dataReader["NOME_PRODUTO"].ToString(),
                    FornecedorProduto = dataReader["FORNECEDOR_PRODUTO"].ToString(),
                    CodigoDeBarras = dataReader["CODIGO_DE_BARRA_PRODUTO"].ToString(),
                    ValorCompraProduto = Convert.ToDouble(dataReader["VALOR_COMPRA_PRODUTO"]),
                    ValorVendaProduto = Convert.ToDouble(dataReader["VALOR_VENDA_PRODUTO"]),
                    ValorComDesconto = Convert.ToDouble(dataReader["VALOR_COM_DESCONTO"]),
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
    }
}
