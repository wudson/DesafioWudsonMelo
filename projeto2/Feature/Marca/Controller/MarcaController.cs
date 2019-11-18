using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Marca.Dao;
using projeto2.Feature.Marca.Model;
using projeto2.Feature.Marca.View;

namespace projeto2.Feature.Marca.Controller
{
    public class MarcaController
    {
        private readonly MarcaDao _dao;
        private readonly FrmMarcas _frmMarcas;

        public MarcaController()
        {
            _dao = new MarcaDao();
            _frmMarcas = new FrmMarcas(this);
        }

        public void AbrirTelaDeMarcas() =>
            _frmMarcas.ShowDialog();

        public void CadastrarMarca(MarcaModel novaMarca)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;

                if (_dao.Cadastrar(novaMarca, cmd))
                    MessageBox.Show(@"Marca cadastrada com sucesso.");
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao cadastrar marca.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao cadastrar marca");
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
                    MessageBox.Show(@"Nenhuma marca foi encontrada.");
                else
                    return marcas;
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao listar marcas.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao listar marcas");
                Console.WriteLine(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

            return new List<MarcaModel>();
        }

        public bool ExcluirMarca(int idGrupo)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;

                if (_dao.Excluir(idGrupo, cmd))
                    MessageBox.Show(@"Marca excluida com sucesso.");
                return true;
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao excluir marca.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao excluir marcas");
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
                    MessageBox.Show(@"Marca alterada com sucesso.");
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao alterar marca.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao alterar marca");
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
