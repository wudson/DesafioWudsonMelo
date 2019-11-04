using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto2.Feature.Promocao.View
{
    public partial class FrmPeriodoPromocao : Form
    {
        public FrmPeriodoPromocao()
        {
            InitializeComponent();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            new FrmProdutosDaPromocaoComDesconto().ShowDialog();
        }
    }
}
