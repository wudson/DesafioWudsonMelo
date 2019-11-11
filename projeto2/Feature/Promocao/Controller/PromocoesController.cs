using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Promocao.Dao;
using projeto2.Feature.Promocao.Model;

namespace projeto2.Feature.Promocao.Controller
{
    public class PromocoesController
    {
        private readonly PromocaoDao _dao;

        public PromocoesController() => _dao = new PromocaoDao();

        public bool CadastrarDado(PromocaoModel promocao)
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                if (_dao.Cadastrar(promocao, cmd))
                {
                    MessageBox.Show(@"Promoção cadastrada com sucesso.", @"Sucesso");
                    return true;
                }
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao cadastrar promoção.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao cadastrar promoção.", @"Erro");
                Console.WriteLine(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return false;
        }

        public IEnumerable<PromocaoModel> ListarDados()
        {
            var conn = Conexao.GetInstancia();
            var cmd = new FbCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                var promocoes = _dao.Listar(cmd).ToList();
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
