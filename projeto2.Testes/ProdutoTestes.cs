using Microsoft.VisualStudio.TestTools.UnitTesting;
using projeto2.Feature.Produto;
using projeto2.Feature.Produto.Controller;
using System.Collections.Generic;
using System.Linq;

namespace projeto2.Testes
{
    [TestClass]
    public class ProdutoTestes
    {
        [TestMethod]
        public void TesteFiltroDeProdutosComRetornoVazio()
        {
            //-- Arrange
            var produtoController = new ProdutoController();
            var produto = new Produto { NomeProduto = "NãoExisteProdutosComEsseNome" };
            var esperado = new List<Produto>();

            //-- Act
            var resultado = produtoController.ListarDados(produto).ToList();

            //-- Assert
            CollectionAssert.AreEqual(esperado, resultado);
        }
    }
}
