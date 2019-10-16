using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Pessoa.Model;

namespace projeto2.Feature.Pessoa.DAO
{
    public class PessoaDao
    {
        public int Cadastrar(object obj)
        {
            var pessoa = (PessoaModel)obj;
            var conn = Conexao.GetInstancia();
            
                const string mSql = @"INSERT into PESSOA (NOME_PESSOA, EMAIL_PESSOA, CPF_PESSOA, RG_PESSOA, SEXO_PESSOA, DATA_NASCIMENTO_PESSOA, TELEFONE_PESSOA) 
                                    Values(@nome, @email, @cpf, @rg, @sexo, @nascimento, @tel) RETURNING Id_PESSOA";

                var cmd = new FbCommand(mSql, conn);
                cmd.Parameters.Add("@nome", FbDbType.VarChar).Value = pessoa.NomePessoa;
                cmd.Parameters.Add("@email", FbDbType.VarChar).Value = pessoa.EmailPessoa;
                cmd.Parameters.Add("@cpf", FbDbType.VarChar).Value = pessoa.CpfPessoa;
                cmd.Parameters.Add("@rg", FbDbType.VarChar).Value = pessoa.RgPessoa;
                cmd.Parameters.Add("@sexo", FbDbType.Char).Value = pessoa.SexoPessoa;
                cmd.Parameters.Add("@nascimento", FbDbType.Date).Value = pessoa.NascimentoPessoa;
                cmd.Parameters.Add("@tel", FbDbType.VarChar).Value = pessoa.TelefonePessoa;

                var idpessoa = int.Parse(cmd.ExecuteScalar().ToString());
                return idpessoa;
        }

        public bool Excluir(int idPessoa)
        {
            var conn = Conexao.GetInstancia();
            try
            {
                conn.Open();
                const string mSql = "DELETE from PESSOA Where ID_PESSOA= @id";
                var cmd = new FbCommand(mSql, conn);
                cmd.Parameters.Add("@id", FbDbType.Integer).Value = idPessoa;
                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Alterar(object obj)
        {
            var pessoa = (PessoaModel)obj;
            var conn = Conexao.GetInstancia();
            try
            {
                conn.Open();
                const string mSql = @"Update PESSOA set NOME_PESSOA = @nome, EMAIL_PESSOA = @email, 
                                    CPF_PESSOA = @cpf, RG_PESSOA = @rg, SEXO_PESSOA = @sexo, DATA_NASCIMENTO_PESSOA = @nascimento,
                                    TELEFONE_PESSOA = @tel
                                    WHERE ID_PESSOA = @id";

                var cmd = new FbCommand(mSql, conn);

                cmd.Parameters.Add("@id", FbDbType.Integer).Value = pessoa.IdPessoa;
                cmd.Parameters.Add("@nome", FbDbType.VarChar).Value = pessoa.NomePessoa;
                cmd.Parameters.Add("@email", FbDbType.VarChar).Value = pessoa.EmailPessoa;
                cmd.Parameters.Add("@cpf", FbDbType.VarChar).Value = pessoa.CpfPessoa;
                cmd.Parameters.Add("@rg", FbDbType.VarChar).Value = pessoa.RgPessoa;
                cmd.Parameters.Add("@sexo", FbDbType.Char).Value = pessoa.SexoPessoa;
                cmd.Parameters.Add("@nascimento", FbDbType.Date).Value = pessoa.NascimentoPessoa;
                cmd.Parameters.Add("@tel", FbDbType.VarChar).Value = pessoa.TelefonePessoa;



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
