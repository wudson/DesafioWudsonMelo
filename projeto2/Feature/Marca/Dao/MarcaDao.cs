using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Marca.Model;
using System;
using System.Collections.Generic;

namespace projeto2.Feature.Marca.Dao
{
    public class MarcaDao
    {
        public bool Cadastrar(MarcaModel marca, FbCommand cmd)
        {

            const string mSql = @"INSERT into MARCA (MARCA) Values(@marca)";

            cmd.CommandText = mSql;
            cmd.Parameters.Add("@marca", FbDbType.VarChar).Value = marca.Marca;
            cmd.ExecuteNonQuery();

            return true;
        }

        public IEnumerable<MarcaModel> Listar(FbCommand cmd)
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

        public bool Excluir(int idMarca, FbCommand cmd)
        {
            const string mSql = "DELETE from MARCA Where ID_MARCA = @id";

            cmd.CommandText = mSql;
            cmd.Parameters.Add("@id", FbDbType.Integer).Value = idMarca;
            cmd.ExecuteNonQuery();

            return true;
        }
    }
}
