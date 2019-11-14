using System;
using projeto2.Feature.Grupo.Dao;
using projeto2.Feature.Grupo.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Grupo.View;

namespace projeto2.Feature.Grupo.Controller
{
    public class GrupoController
    {
        private readonly GrupoDao _dao;
        private readonly FrmGrupos _frmGrupos;

        public GrupoController()
        {
            _dao = new GrupoDao();
            _frmGrupos = new FrmGrupos(this);
        }

        public void AbrirTelaDeGrupos() =>
            _frmGrupos.ShowDialog();

        public void CadastrarGrupo(GrupoModel novoGrupo)
        {
            try
            {
                if (_dao.Cadastrar(novoGrupo))
                    MessageBox.Show(@"Grupo cadastrado com sucesso.");
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao cadastrar grupo.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao cadastrar grupo");
                Console.WriteLine(ex);
            }
        }

        public IEnumerable<GrupoModel> ListarGrupos()
        {
            try
            {
                var grupos = _dao.Listar().ToList();
                if (grupos.Count < 1)
                    MessageBox.Show(@"Nenhum grupo foi encontrado.");
                else
                    return grupos;
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao listar grupos.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao listar grupos");
                Console.WriteLine(ex);
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
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao excluir grupo.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao excluir grupo");
                Console.WriteLine(ex);
            }
            return false;
        }
    }
}
