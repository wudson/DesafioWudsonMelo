﻿using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Grupo.Model;
using System;
using System.Collections.Generic;

namespace projeto2.Feature.Grupo.Dao
{
    public class GrupoDao
    {
        public virtual bool Cadastrar(GrupoModel grupo, FbCommand cmd)
        {
            const string mSql = @"INSERT into GRUPO (GRUPO) Values(@grupo)";

            cmd.CommandText = mSql;

            cmd = AdicionarParametrosDeCadastro(grupo, cmd);

            cmd.ExecuteNonQuery();
            return true;
        }

        public FbCommand AdicionarParametrosDeCadastro(GrupoModel grupo, FbCommand cmd)
        {
            cmd.Parameters.Add("@grupo", FbDbType.VarChar).Value = grupo.Grupo;
            return cmd;
        }

        public virtual IEnumerable<GrupoModel> Listar(FbCommand cmd)
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

        public virtual bool Excluir(int idGrupo, FbCommand cmd)
        {
            const string mSql = "DELETE from GRUPO Where ID_GRUPO = @id";
            cmd.CommandText = mSql;

            cmd = AdicionarParametrosDeExclusao(idGrupo, cmd);
            cmd.ExecuteNonQuery();
            return true;
        }

        public FbCommand AdicionarParametrosDeExclusao(int idGrupo, FbCommand cmd)
        {
            cmd.Parameters.Add("@id", FbDbType.Integer).Value = idGrupo;
            return cmd;
        }

        public virtual bool Alterar(GrupoModel grupo, FbCommand cmd)
        {
            const string mSql = @"UPDATE GRUPO set GRUPO = @grupo WHERE ID_GRUPO = @id";

            cmd.CommandText = mSql;

            cmd = AdicionarParametrosDeEdicao(grupo, cmd);

            cmd.ExecuteNonQuery();
            return true;
        }

        public FbCommand AdicionarParametrosDeEdicao(GrupoModel grupo, FbCommand cmd)
        {
            cmd.Parameters.Add("@grupo", FbDbType.VarChar).Value = grupo.Grupo;
            cmd.Parameters.Add("@id", FbDbType.Integer).Value = grupo.IdGrupo;
            return cmd;
        }
    }
}
