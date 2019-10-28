using System;
using System.Collections.Generic;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Marca.Model;

namespace projeto2.Feature.Marca.Dao
{
    public class MarcaDao
    {
        public bool Cadastrar(string marca)
        {
            var conn = Conexao.GetInstancia();
            conn.Open();
            const string mSql = @"INSERT into MARCA (MARCA) Values(@marca)";

            var cmd = new FbCommand(mSql, conn);
            try
            {
                cmd.Parameters.Add("@marca", FbDbType.VarChar).Value = marca;

                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public IEnumerable<MarcaModel> Listar()
        {
            var conn = Conexao.GetInstancia();
            conn.Open();

            const string mSql = @"Select * from MARCA";
            var cmd = new FbCommand(mSql, conn);
            try
            {
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
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public bool Excluir(int idMarca)
        {
            var conn = Conexao.GetInstancia();
            conn.Open();
            const string mSql = "DELETE from MARCA Where ID_MARCA = @id";
            var cmd = new FbCommand(mSql, conn);
            try
            {
                cmd.Parameters.Add("@id", FbDbType.Integer).Value = idMarca;
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
