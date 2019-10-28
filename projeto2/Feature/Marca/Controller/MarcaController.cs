using System.Collections.Generic;
using System.Windows.Forms;
using projeto2.Feature.Marca.Dao;
using projeto2.Feature.Marca.Model;

namespace projeto2.Feature.Marca.Controller
{
    public class MarcaController
    {
        public void CadastrarMarca(string novaMarca)
        {
            try
            {
                if (new MarcaDao().Cadastrar(novaMarca))
                    MessageBox.Show(@"Marca cadastrada com sucesso.");
            }
            catch
            {
                MessageBox.Show(@"Problemas ao cadastrar marca.");
            }

        }

        public IEnumerable<MarcaModel> ListarMarcas() => new MarcaDao().Listar();

        public bool ExcluirMarca(int idGrupo)
        {
            try
            {
                if (new MarcaDao().Excluir(idGrupo))
                    MessageBox.Show(@"Marca excluida com sucesso.");
                return true;
            }
            catch
            {
                MessageBox.Show(@"Problemas ao excluir marca.");
                return false;
            }
        }
    }
}
