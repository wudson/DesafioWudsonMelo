using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using projeto2.Feature.Marca.Dao;
using projeto2.Feature.Marca.Model;

namespace projeto2.Feature.Marca.Controller
{
    public class MarcaController
    {
        private readonly MarcaDao _dao;

        public MarcaController() =>
            _dao = new MarcaDao();

        public void CadastrarMarca(MarcaModel novaMarca)
        {
            try
            {
                if (_dao.Cadastrar(novaMarca))
                    MessageBox.Show(@"Marca cadastrada com sucesso.");
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao cadastrar marca.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao cadastrar marca");
                Console.WriteLine(ex);
            }

        }

        public IEnumerable<MarcaModel> ListarMarcas()
        {
            try
            {
                var marcas = _dao.Listar().ToList();
                if (marcas.Count < 1)
                    MessageBox.Show(@"Nenhuma marca foi encontrada.");
                else
                    return marcas;
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao listar marcas.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao listar marcas");
                Console.WriteLine(ex);
            }

            return new List<MarcaModel>();
        }

        public bool ExcluirMarca(int idGrupo)
        {
            try
            {
                if (_dao.Excluir(idGrupo))
                    MessageBox.Show(@"Marca excluida com sucesso.");
                return true;
            }
            catch (FbException ex)
            {
                MessageBox.Show(@"Problemas no banco de dados ao excluir marca.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problemas ao excluir marcas");
                Console.WriteLine(ex);
            }

            return false;
        }
    }
}
