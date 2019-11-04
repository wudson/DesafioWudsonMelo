using FirebirdSql.Data.FirebirdClient;

namespace projeto2
{
    public static class Conexao
    {
        private static FbConnection InstanciaFireBird { get; set; }

        private const string StringConexao =
            "User = SYSDBA; Password=masterkey; Database=C:/Users/Wudso/Documents/IBExpert_Portable/banco.fdb;DataSource=localhost; Dialect=3; Charset=WIN1252; Pooling=true;";

        public static FbConnection GetInstancia() => InstanciaFireBird ?? CriaConexao();

        public static FbConnection CriaConexao() => InstanciaFireBird = new FbConnection(StringConexao);
    }
}