using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Promocao.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace projeto2.Feature.Promocao.Dao
{
    public class PromocaoDao
    {
        public bool Cadastrar(PromocaoModel promocao, FbCommand cmd)
        {
            const string mSql = @"INSERT into promocao (NOME_PROMOCAO, TIPO_PROMOCAO, STATUS_PROMOCAO, 
                                DATA_INICIO_PROMOCAO, DATA_FIM_PROMOCAO) 
                                Values(@nome, @tipo, @status, @dataInicio, @dataFim)";

            cmd.CommandText = mSql;

            cmd.Parameters.Add("@nome", FbDbType.VarChar).Value = promocao.NomePromocao;
            cmd.Parameters.Add("@tipo", FbDbType.VarChar).Value = promocao.TipoPromocao;
            cmd.Parameters.Add("@status", FbDbType.VarChar).Value = promocao.StatusPromocao;
            cmd.Parameters.Add("@dataInicio", FbDbType.Date).Value = promocao.DataInicio;
            cmd.Parameters.Add("@dataFim", FbDbType.Date).Value = promocao.DataFim;
            cmd.ExecuteNonQuery();

            return true;
        }

        public IEnumerable<PromocaoModel> Listar(FbCommand cmd)
        {
            var sql = new StringBuilder();
            sql.Append(@"Select * from PROMOCAO WHERE (1=1)");

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
                    DataFim = Convert.ToDateTime(dataReader["DATA_FIM_PROMOCAO"])
                });
            }
            return promocoes;
        }
    }
}
