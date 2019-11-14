using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Grupo.Model;
using System;
using System.Collections.Generic;

namespace projeto2.Feature.Grupo.Dao
{
    public class GrupoDao
    {
        public bool Cadastrar(GrupoModel grupo, FbCommand cmd)
        {
            const string mSql = @"INSERT into GRUPO (GRUPO) Values(@grupo)";

            cmd.CommandText = mSql;

            cmd.Parameters.Add("@grupo", FbDbType.VarChar).Value = grupo.Grupo;

            cmd.ExecuteNonQuery();
            return true;
        }

        public IEnumerable<GrupoModel> Listar(FbCommand cmd)
        {
            const string mSql = @"Select * from GRUPO";

            cmd.CommandText = mSql;

            var dataReader = cmd.ExecuteReader();
            var grupos = new List<GrupoModel>();
            while (dataReader.Read())
                grupos.Add(new GrupoModel
                {
                    IdGrupo = Convert.ToInt32(dataReader["ID_GRUPO"]),
                    Grupo = dataReader["GRUPO"].ToString()
                });
            return grupos;
        }

        public bool Excluir(int idGrupo, FbCommand cmd)
        {
            const string mSql = "DELETE from GRUPO Where ID_GRUPO = @id";
            cmd.CommandText = mSql;

            cmd.Parameters.Add("@id", FbDbType.Integer).Value = idGrupo;
            cmd.ExecuteNonQuery();
            return true;
        }
    }
}
