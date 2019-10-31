using System;
using System.Windows.Forms;

namespace projeto2
{
    public class Propriedade
    {
        public static object BuscarPropriedadeComPonto(DataGridView grid, DataGridViewCellFormattingEventArgs e)
        {
            if (grid.Rows[e.RowIndex].DataBoundItem != null && grid.Columns[e.ColumnIndex].DataPropertyName.Contains("."))
                return BuscarPropriedade(grid.Rows[e.RowIndex].DataBoundItem, grid.Columns[e.ColumnIndex].DataPropertyName);

            return e.Value;
        }

        private static object BuscarPropriedade(object propriedade, string nomePropriedade)
        {
            var valorPropriedade = "";
            if (nomePropriedade.Contains("."))
            {
                var nomeDaPropriedadeRestante = nomePropriedade.Substring(0, nomePropriedade.IndexOf(".", StringComparison.Ordinal));
                var propriedades = propriedade.GetType().GetProperties();
                foreach (var propertyInfo in propriedades)
                {
                    if (propertyInfo.Name != nomeDaPropriedadeRestante) continue;
                    valorPropriedade = (string)BuscarPropriedade(
                        propertyInfo.GetValue(propriedade, null),
                        nomePropriedade.Substring(nomePropriedade.IndexOf(".", StringComparison.Ordinal) + 1));
                    break;
                }
            }
            else
            {
                var tipoDaPropriedade = propriedade.GetType();
                var informacoesDaPropriedade = tipoDaPropriedade.GetProperty(nomePropriedade);
                if (informacoesDaPropriedade != null) valorPropriedade = informacoesDaPropriedade.GetValue(propriedade, null).ToString();
            }
            return valorPropriedade;
        }
    }
}
