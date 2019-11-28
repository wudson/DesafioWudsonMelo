using DevExpress.XtraEditors;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Promocao.Dao;
using projeto2.Feature.Promocao.Model;
using projeto2.Feature.Promocao.View.Dev;
using projeto2.Feature.Promocao.View.WinForms;
using projeto2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace projeto2.Feature.Promocao.Controller
{
    public class PromocoesController : IFrmController
    {
        private FrmPromocoes _frmPromocoes;
        private FrmPromocoesDev _frmPromocoesDev;
        private readonly PromocaoDao _dao;
        private readonly bool _teste;

        private readonly CadastroDePromocaoController _cadastroDePromocaoController;
        private readonly ProdutosDaPromocaoController _produtosDaPromocaoController;

        public PromocoesController(PromocaoDao dao = null, bool teste = false)
        {
            _dao = dao ?? new PromocaoDao();
            _teste = teste;

            _frmPromocoes = new FrmPromocoes(this);
            _frmPromocoesDev = new FrmPromocoesDev(this);

            _cadastroDePromocaoController = new CadastroDePromocaoController();
            _produtosDaPromocaoController = new ProdutosDaPromocaoController();
        }

        public void AbrirTela()
        {
            if (!ClasseComVariaveisGlobais.UsarDev)
            {
                (_frmPromocoes = new FrmPromocoes(this)).ShowDialog();
                _frmPromocoes.Dispose();
            }
            else
            {
                (_frmPromocoesDev = new FrmPromocoesDev(this)).ShowDialog();
                _frmPromocoesDev.Dispose();
            }
        }

        public void AbrirTelaProdutosDaPromocao(List<PromocaoModel> promocao) => 
            _produtosDaPromocaoController.AbrirTelaComProdutosDaPromocao(promocao);

        public void AbrirTelaCadastroDePromocao() => 
            _cadastroDePromocaoController.AbrirTela();

        public IEnumerable<PromocaoModel> ListarDados(FiltrosPromocaoModel filtros)
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
                }
                var promocoes = _dao.Listar(cmd, filtros).ToList();
                if (promocoes.Count < 1)
                    XtraMessageBox.Show(@"Nenhuma promoção foi encontrada.");
                else
                    return promocoes;
            }
            catch (FbException ex)
            {
                XtraMessageBox.Show(@"Problemas no banco de dados ao listar promoções.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Problemas ao listar promoções.");
                Console.WriteLine(ex);
            }
            finally
            {
                cmd?.Dispose();
                conn.Close();
            }

            return new List<PromocaoModel>();
        }
    }
}
