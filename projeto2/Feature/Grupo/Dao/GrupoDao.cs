using System;
using System.Collections.Generic;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Grupo.Model;

namespace projeto2.Feature.Grupo.Dao
{
    public class GrupoDao
    {
        public bool Cadastrar(string grupo)
        {
            var conn = Conexao.GetInstancia();
            conn.Open();
            const string mSql = @"INSERT into GRUPO (GRUPO) Values(@grupo)";

            var cmd = new FbCommand(mSql, conn);
            try
            {
                cmd.Parameters.Add("@grupo", FbDbType.VarChar).Value = grupo;

                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public IEnumerable<GrupoModel> Listar()
        {
            var conn = Conexao.GetInstancia();
            conn.Open();

            const string mSql = @"Select * from GRUPO";
            var cmd = new FbCommand(mSql, conn);
            try
            {
                var dataReader = cmd.ExecuteReader();
                var grupos = new List<GrupoModel>();
                while (dataReader.Read())
                {
                    grupos.Add(new GrupoModel
                    {
                        IdGrupo = Convert.ToInt32(dataReader["ID_GRUPO"]),
                        Grupo = dataReader["GRUPO"].ToString()
                    });
                }
                return grupos;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public bool Excluir(int idGrupo)
        {
            var conn = Conexao.GetInstancia();
            conn.Open();
            const string mSql = "DELETE from GRUPO Where ID_GRUPO= @id";
            var cmd = new FbCommand(mSql, conn);
            try
            {
                cmd.Parameters.Add("@id", FbDbType.Integer).Value = idGrupo;
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
