using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto2.Feature.Grupo.Dao;
using projeto2.Feature.Grupo.Model;

namespace projeto2.Feature.Grupo.Controller
{
    public class GrupoController
    {
        public void CadastrarGrupo(string novoGrupo)
        {
            try
            {
                if (new GrupoDao().Cadastrar(novoGrupo))
                    MessageBox.Show(@"Grupo cadastrado com sucesso.");
            }
            catch
            {
                MessageBox.Show(@"Problemas ao cadastrar grupo.");
            }

        }

        public IEnumerable<GrupoModel> ListarGrupos() => new GrupoDao().Listar();

        public bool ExcluirGrupo(int idGrupo)
        {
            try
            {
                if (new GrupoDao().Excluir(idGrupo))
                    MessageBox.Show(@"Grupo excluido com sucesso.");
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
