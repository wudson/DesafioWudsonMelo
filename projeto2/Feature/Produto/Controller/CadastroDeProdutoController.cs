
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Grupo.Controller;
using projeto2.Feature.Grupo.Model;
using projeto2.Feature.Marca.Controller;
using projeto2.Feature.Marca.Model;
using projeto2.Feature.Produto.Dao;
using projeto2.Feature.Produto.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projeto2.Feature.Produto.Controller
{
    public class CadastroDeProdutoController
    {
        private readonly ProdutoDao _dao;
        private FrmCadastroDeProduto _frmCadastroDeProdutos;
        private readonly GrupoController _grupoController;
        private readonly MarcaController _marcaController;

        public CadastroDeProdutoController()
        {
            _dao = new ProdutoDao();
            _marcaController = new MarcaController();
            _grupoController = new GrupoController();
        }

        public void AbrirTela()
        {
            (_frmCadastroDeProdutos = new FrmCadastroDeProduto(this)).ShowDialog();
            _frmCadastroDeProdutos.Dispose();
        }

        public void AbrirTelaParaAlterar(Produto produto)
        {
            (_frmCadastroDeProdutos = new FrmCadastroDeProduto(this)).RecebeProdutoParaAlterar(produto);
            _frmCadastroDeProdutos.Dispose();
        }

        public bool CadastrarDado(Produto produto)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                if (_dao.Cadastrar(produto, cmd))
                {
                    MessageBox.Show(@"Produto cadastrado com sucesso.", @"Sucesso");
                    return true;
                }
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao cadastrar produto.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao cadastrar produto.", @"Erro");
                Console.WriteLine(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return false;
        }

        public IEnumerable<GrupoModel> ListarGrupos() => _grupoController.ListarGrupos();

        public IEnumerable<MarcaModel> ListarMarcas() => _marcaController.ListarMarcas();

        public bool AlterarDado(Produto produto)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                if (_dao.Alterar(produto, cmd))
                {
                    MessageBox.Show(@"Produto alterado com sucesso.", @"Sucesso");
                    return true;
                }
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao alterar produto.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao alterar produto", @"Erro");
                Console.WriteLine(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return false;
        }
    }
}
