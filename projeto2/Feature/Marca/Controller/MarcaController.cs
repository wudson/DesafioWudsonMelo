using DevExpress.XtraEditors;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Marca.Dao;
using projeto2.Feature.Marca.Model;
using projeto2.Feature.Marca.View.Dev;
using projeto2.Feature.Marca.View.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using projeto2.Interfaces;

namespace projeto2.Feature.Marca.Controller
{
    public class MarcaController : IFrmController
    {
        private readonly MarcaDao _dao;
        private readonly FrmMarcas _frmMarcas;
        private readonly FrmMarcasDev _frmMarcasDev;

        public MarcaController()
        {
            _dao = new MarcaDao();
            _frmMarcas = new FrmMarcas(this);
            _frmMarcasDev = new FrmMarcasDev(this);
        }

        public void AbrirTela()
        {
            if (!ClasseComVariaveisGlobais.UsarDev)
                _frmMarcas.ShowDialog();
            else
                _frmMarcasDev.ShowDialog();
        }

        public void CadastrarMarca(MarcaModel novaMarca)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;

                if (_dao.Cadastrar(novaMarca, cmd))
                    XtraMessageBox.Show(@"Marca cadastrada com sucesso.");
            }
            catch (FbException ex)
            {
                XtraMessageBox.Show(@"Problemas no banco de dados ao cadastrar marca.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Problemas ao cadastrar marca");
                Console.WriteLine(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public IEnumerable<MarcaModel> ListarMarcas()
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;

                var marcas = _dao.Listar(cmd).ToList();
                if (marcas.Count < 1)
                    XtraMessageBox.Show(@"Nenhuma marca foi encontrada.");
                else
                    return marcas;
            }
            catch (FbException ex)
            {
                XtraMessageBox.Show(@"Problemas no banco de dados ao listar marcas.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Problemas ao listar marcas");
                Console.WriteLine(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

            return new List<MarcaModel>();
        }

        public bool ExcluirMarca(int idMarca)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;

                if (_dao.Excluir(idMarca, cmd))
                    XtraMessageBox.Show(@"Marca excluida com sucesso.");
                return true;
            }
            catch (FbException ex)
            {
                XtraMessageBox.Show(@"Problemas no banco de dados ao excluir marca.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Problemas ao excluir marcas");
                Console.WriteLine(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

            return false;
        }

        public void AlterarMarca(MarcaModel marca)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;

                if (_dao.Alterar(marca, cmd))
                    XtraMessageBox.Show(@"Marca alterada com sucesso.");
            }
            catch (FbException ex)
            {
                XtraMessageBox.Show(@"Problemas no banco de dados ao alterar marca.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Problemas ao alterar marca");
                Console.WriteLine(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public void AlterarOuCadastrarMarca(MarcaModel marca)
        {
            if(marca.IdMarca > 0)
                AlterarMarca(marca);
            else
                CadastrarMarca(marca);
        }
    }
}
