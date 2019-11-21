using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Promocao.Dao;
using projeto2.Feature.Promocao.Model;
using projeto2.Feature.Promocao.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using projeto2.Feature.Promocao.View.WinForms;

namespace projeto2.Feature.Promocao.Controller
{
    public class CadastroDePromocaoController
    {
        private readonly PromocaoDao _dao;
        private FrmCadastroDePromcao _frmCadastroDePromcao;
        private readonly ProdutosAdicionadosNaPromocaoController _produtosAdicionadosNaPromocaoController;

        public CadastroDePromocaoController()
        {
            _dao = new PromocaoDao();
            _produtosAdicionadosNaPromocaoController = new ProdutosAdicionadosNaPromocaoController();
        }

        public void AbrirTelaCadastroDePromocao()
        {
            (_frmCadastroDePromcao = new FrmCadastroDePromcao(this)).ShowDialog();
            _frmCadastroDePromcao.Dispose();
        }

        public IList<PromocaoModel> RetornarProdutos(List<Produto.Produto> produtos) => 
            _produtosAdicionadosNaPromocaoController.RetornarProdutos(produtos);

        public bool CadastrarDado(PromocaoModel promocao)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.Transaction = conn.BeginTransaction();

                if (_dao.Cadastrar(promocao, cmd))
                {
                    MessageBox.Show(@"Promoção cadastrada com sucesso.", @"Sucesso");
                    cmd.Transaction.Commit();
                    return true;
                }
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao cadastrar promoção.");
                cmd.Transaction.Rollback();
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao cadastrar promoção.", @"Erro");
                cmd.Transaction.Rollback();
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
