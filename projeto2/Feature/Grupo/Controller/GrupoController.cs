using DevExpress.XtraEditors;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Grupo.Dao;
using projeto2.Feature.Grupo.Model;
using projeto2.Feature.Grupo.View.Dev;
using projeto2.Feature.Grupo.View.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using projeto2.Interfaces;

namespace projeto2.Feature.Grupo.Controller
{
    public class GrupoController : IFrmController
    {
        private readonly GrupoDao _dao;
        private readonly FrmGrupos _frmGrupos;
        private readonly FrmGruposDev _frmGruposDev;

        public GrupoController()
        {
            _dao = new GrupoDao();
            _frmGrupos = new FrmGrupos(this);
            _frmGruposDev = new FrmGruposDev(this);
        }

        public void AbrirTela()
        {
            if (!ClasseComVariaveisGlobais.UsarDev)
                _frmGrupos.ShowDialog();
            else
                _frmGruposDev.ShowDialog();
        }

        public void CadastrarGrupo(GrupoModel novoGrupo)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;

                if (_dao.Cadastrar(novoGrupo, cmd))
                    XtraMessageBox.Show(@"Grupo cadastrado com sucesso.");
            }
            catch (FbException ex)
            {
                XtraMessageBox.Show(@"Problemas no banco de dados ao cadastrar grupo.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Problemas ao cadastrar grupo");
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
                    XtraMessageBox.Show(@"Nenhum grupo foi encontrado.");
                else
                    return grupos;
            }
            catch (FbException ex)
            {
                XtraMessageBox.Show(@"Problemas no banco de dados ao listar grupos.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Problemas ao listar grupos");
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
                    XtraMessageBox.Show(@"Grupo excluído com sucesso.");
                return true;
            }
            catch (FbException ex)
            {
                XtraMessageBox.Show(@"Problemas no banco de dados ao excluir grupo.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Problemas ao excluir grupo");
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
                    XtraMessageBox.Show(@"Grupo alterado com sucesso.");
            }
            catch (FbException ex)
            {
                XtraMessageBox.Show(@"Problemas no banco de dados ao alterar grupo.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Problemas ao alterar grupo");
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
