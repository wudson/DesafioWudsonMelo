using projeto2.Feature.Promocao.Model;
using projeto2.Feature.Promocao.View.Dev;
using projeto2.Feature.Promocao.View.WinForms;
using System.Collections.Generic;

namespace projeto2.Feature.Promocao.Controller
{
    public class ProdutosDaPromocaoController
    {
        public void AbrirTelaComProdutosDaPromocao(List<PromocaoModel> promocao)
        {
            if(!ClasseComVariaveisGlobais.UsarDev)
                new FrmProdutosDaPromocao(promocao).ShowDialog();
            else
                new FrmProdutosDaPromocaoDev(promocao).ShowDialog();
        }
    }
}
