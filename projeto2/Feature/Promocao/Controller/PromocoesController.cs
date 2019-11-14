using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Promocao.Dao;
using projeto2.Feature.Promocao.Model;
using projeto2.Feature.Promocao.View;

namespace projeto2.Feature.Promocao.Controller
{
    public class PromocoesController
    {
        private readonly FrmPromocoes _frmPromocoes;
        private readonly PromocaoDao _dao;

        private readonly CadastroDePromocaoController _cadastroDePromocaoController;
        private readonly ProdutosDaPromocaoController _produtosDaPromocaoController;

        public PromocoesController()
        {
            _dao = new PromocaoDao();

            _frmPromocoes = new FrmPromocoes(this);

            _cadastroDePromocaoController = new CadastroDePromocaoController();
            _produtosDaPromocaoController = new ProdutosDaPromocaoController();
        }

        public void AbrirTelaDePromocao() =>
            _frmPromocoes.ShowDialog();

        public void AbrirTelaProdutosDaPromocao(List<PromocaoModel> promocao) => 
            _produtosDaPromocaoController.AbrirTelaComProdutosDaPromocao(promocao);

        public void AbrirTelaCadastroDePromocao()
        {
            _cadastroDePromocaoController.AbrirTelaCadastroDePromocao();
        }

        public IEnumerable<PromocaoModel> ListarDados(FiltrosPromocaoModel filtros)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                var promocoes = _dao.Listar(cmd, filtros).ToList();
                if (promocoes.Count < 1)
                    MessageBox.Show(@"Nenhuma promoção foi encontrada.");
                else
                    return promocoes;
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao listar promoções.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao listar promoções.");
                Console.WriteLine(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

            return new List<PromocaoModel>();
        }
    }
}
