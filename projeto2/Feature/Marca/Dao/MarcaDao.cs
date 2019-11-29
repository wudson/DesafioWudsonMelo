using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Marca.Model;
using System;
using System.Collections.Generic;

namespace projeto2.Feature.Marca.Dao
{
    public class MarcaDao
    {
        public virtual bool Cadastrar(MarcaModel marca, FbCommand cmd)
        {

            const string mSql = @"INSERT into MARCA (MARCA) Values(@marca)";

            cmd.CommandText = mSql;
            cmd = AdicionarParametrosDeCadastro(marca, cmd);
            cmd.ExecuteNonQuery();

            return true;
        }

        public FbCommand AdicionarParametrosDeCadastro(MarcaModel marca, FbCommand cmd)
        {
            cmd.Parameters.Add("@marca", FbDbType.VarChar).Value = marca.Marca;
            return cmd;
        }

        public virtual IEnumerable<MarcaModel> Listar(FbCommand cmd)
        {
            const string mSql = @"Select * from MARCA";

            cmd.CommandText = mSql;

            var dataReader = cmd.ExecuteReader();
            var marcas = new List<MarcaModel>();
            while (dataReader.Read())
            {
                marcas.Add(new MarcaModel()
                {
                    IdMarca = Convert.ToInt32(dataReader["ID_MARCA"]),
                    Marca = dataReader["MARCA"].ToString()
                });
            }
            return marcas;
        }

        public virtual bool Excluir(int idMarca, FbCommand cmd)
        {
            const string mSql = "DELETE from MARCA Where ID_MARCA = @id";

            cmd.CommandText = mSql;
            cmd = AdicionarParametrosDeExclusao(idMarca, cmd);
            cmd.ExecuteNonQuery();

            return true;
        }

        public FbCommand AdicionarParametrosDeExclusao(int idMarca, FbCommand cmd)
        {
            cmd.Parameters.Add("@id", FbDbType.Integer).Value = idMarca;
            return cmd;
        }

        public virtual bool Alterar(MarcaModel marca, FbCommand cmd)
        {
            const string mSql = @"UPDATE MARCA set MARCA = @marca WHERE ID_MARCA = @id";

            cmd.CommandText = mSql;

            cmd = AdicionarParametrosDeEdicao(marca, cmd);

            cmd.ExecuteNonQuery();
            return true;
        }

        public FbCommand AdicionarParametrosDeEdicao(MarcaModel marca, FbCommand cmd)
        {
            cmd.Parameters.Add("@marca", FbDbType.VarChar).Value = marca.Marca;
            cmd.Parameters.Add("@id", FbDbType.Integer).Value = marca.IdMarca;
            return cmd;
        }
    }
}
