using DevExpress.XtraEditors;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Promocao.Dao;
using projeto2.Feature.Promocao.Model;
using projeto2.Feature.Promocao.View.Dev;
using projeto2.Feature.Promocao.View.WinForms;
using System;
using System.Collections.Generic;
using projeto2.Interfaces;

namespace projeto2.Feature.Promocao.Controller
{
    public class CadastroDePromocaoController : IFrmController
    {
        private readonly PromocaoDao _dao;
        private readonly bool _teste;
        private FrmCadastroDePromcao _frmCadastroDePromcao;
        private FrmCadastroDePromocaoDev _frmCadastroDePromcaoDev;
        private readonly ProdutosAdicionadosNaPromocaoController _produtosAdicionadosNaPromocaoController;

        public CadastroDePromocaoController(PromocaoDao dao = null, bool teste = false)
        {
            _dao = dao ?? new PromocaoDao();
            _teste = teste;
            _produtosAdicionadosNaPromocaoController = new ProdutosAdicionadosNaPromocaoController();
        }

        public void AbrirTela()
        {
            if (!ClasseComVariaveisGlobais.UsarDev)
            {
                (_frmCadastroDePromcao = new FrmCadastroDePromcao(this)).ShowDialog();
                _frmCadastroDePromcao.Dispose();
            }
            else
            {
                (_frmCadastroDePromcaoDev = new FrmCadastroDePromocaoDev(this)).ShowDialog();
                _frmCadastroDePromcaoDev.Dispose();
            }
        }

        public IList<PromocaoModel> RetornarProdutos(List<Produto.Produto> produtos) =>
            _produtosAdicionadosNaPromocaoController.RetornarProdutos(produtos);

        public bool CadastrarDado(PromocaoModel promocao)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                if (_teste)
                    cmd = null;
                else
                {

                    conn.Open();
                    cmd.Connection = conn;
                    cmd.Transaction = conn.BeginTransaction();
                }

                if (_dao.Cadastrar(promocao, cmd))
                {
                    XtraMessageBox.Show(@"Promoção cadastrada com sucesso.", @"Sucesso");
                    cmd?.Transaction.Commit();
                    return true;
                }
            }
            catch (FbException ex)
            {
                XtraMessageBox.Show(@"Problemas no banco de dados ao cadastrar promoção.");
                cmd?.Transaction.Rollback();
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Problemas ao cadastrar promoção.", @"Erro");
                cmd?.Transaction.Rollback();
                Console.WriteLine(ex);
            }
            finally
            {
                cmd?.Dispose();
                conn.Close();
            }
            return false;
        }
    }
}
