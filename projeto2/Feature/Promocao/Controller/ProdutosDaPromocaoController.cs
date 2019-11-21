using System.Collections.Generic;
using projeto2.Feature.Promocao.Model;
using projeto2.Feature.Promocao.View;
using projeto2.Feature.Promocao.View.WinForms;

namespace projeto2.Feature.Promocao.Controller
{
    public class ProdutosDaPromocaoController
    {
        public void AbrirTelaComProdutosDaPromocao(List<PromocaoModel> promocao) => 
            new FrmProdutosDaPromocao(promocao).ShowDialog();
    }
}
