using System.Collections.Generic;
using System.Windows.Forms;
using projeto2.Feature.Marca.Dao;
using projeto2.Feature.Marca.Model;

namespace projeto2.Feature.Marca.Controller
{
    public class MarcaController
    {
        private readonly MarcaDao _dao;

        public MarcaController() =>
            _dao = new MarcaDao();

        public void CadastrarMarca(MarcaModel novaMarca)
        {
            try
            {
                if (_dao.Cadastrar(novaMarca))
                    MessageBox.Show(@"Marca cadastrada com sucesso.");
            }
            catch
            {
                MessageBox.Show(@"Problemas ao cadastrar marca.");
            }

        }

        public IEnumerable<MarcaModel> ListarMarcas()
        {
            try
            {
                return _dao.Listar();
            }
            catch
            {
                MessageBox.Show(@"Problemas ao listar grupos");
            }

            return new List<MarcaModel>();
        }

        public bool ExcluirMarca(int idGrupo)
        {
            try
            {
                if (_dao.Excluir(idGrupo))
                    MessageBox.Show(@"Marca excluida com sucesso.");
                return true;
            }
            catch
            {
                MessageBox.Show(@"Problemas ao excluir marca.");
            }
            return false;
        }
    }
}
