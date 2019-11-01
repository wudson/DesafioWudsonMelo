using projeto2.Feature.Grupo.Dao;
using projeto2.Feature.Grupo.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projeto2.Feature.Grupo.Controller
{
    public class GrupoController
    {
        private readonly GrupoDao _dao;

        public GrupoController() =>
            _dao = new GrupoDao();

        public void CadastrarGrupo(GrupoModel novoGrupo)
        {
            try
            {
                if (_dao.Cadastrar(novoGrupo))
                    MessageBox.Show(@"Grupo cadastrado com sucesso.");
            }
            catch
            {
                MessageBox.Show(@"Problemas ao cadastrar grupo.");
            }

        }

        public IEnumerable<GrupoModel> ListarGrupos()
        {
            try
            {
                return _dao.Listar();
            }
            catch
            {
                MessageBox.Show(@"Problemas ao listar grupos");
            }

            return new List<GrupoModel>();
        }

        public bool ExcluirGrupo(int idGrupo)
        {
            try
            {
                if (_dao.Excluir(idGrupo))
                    MessageBox.Show(@"Grupo excluído com sucesso.");
                return true;
            }
            catch
            {
                MessageBox.Show(@"Problemas ao excluir grupo.");
            }
            return false;
        }
    }
}
