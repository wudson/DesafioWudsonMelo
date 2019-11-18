using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Grupo.Dao;
using projeto2.Feature.Grupo.Model;
using projeto2.Feature.Grupo.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;

                if (_dao.Cadastrar(novoGrupo, cmd))
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
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public IEnumerable<GrupoModel> ListarGrupos()
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;

                var grupos = _dao.Listar(cmd).ToList();
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
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

            return new List<GrupoModel>();
        }

        public bool ExcluirGrupo(int idGrupo)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;

                if (_dao.Excluir(idGrupo, cmd))
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
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return false;
        }

        public void AlterarGrupo(GrupoModel grupo)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;

                if (_dao.Alterar(grupo, cmd))
                    MessageBox.Show(@"Grupo alterado com sucesso.");
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao alterar grupo.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao alterar grupo");
                Console.WriteLine(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public void AlterarOuCadastrarGrupo(GrupoModel grupo)
        {
            if (grupo.IdGrupo > 0)
                AlterarGrupo(grupo);
            else 
                CadastrarGrupo(grupo);
        }
    }
}
