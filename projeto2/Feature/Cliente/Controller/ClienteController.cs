using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using projeto2.Feature.Cliente.Dao;
using projeto2.Feature.Cliente.Model;

namespace projeto2.Feature.Cliente.Controller
{
    public class ClienteController
    {
        public IList<object> BuscarTodosOsDados() => new ClienteDao().Listar();


        public bool AlterarDado(ClienteModel cliente)
        {
            try
            {
                if (new ClienteDao().Alterar(cliente))
                {
                    MessageBox.Show(@"Cliente alterado com sucesso.", @"Sucesso");
                    return true;
                }
            }
            catch
            {
                MessageBox.Show(@"Problemas ao alterar cliente.", @"Erro");
            }
            return false;
        }

        public bool CadastrarDado(ClienteModel cliente)
        {
            try
            {
                if (new ClienteDao().Cadastrar(cliente))
                {
                    MessageBox.Show(@"Cliente cadastrado com sucesso.", @"Sucesso");
                    return true;
                }
            }
            catch
            {
                MessageBox.Show(@"Problemas ao cadastrar cliente.", @"Erro");
            }

            return false;
        }

        public ClienteModel BuscarDado(int idPessoa) => (ClienteModel)new ClienteDao().Buscar(idPessoa);

        public bool ExcluirDado(int idPessoa)
        {
            if (new ClienteDao().Excluir(idPessoa))
            {
                MessageBox.Show(@"Cliente excluido com sucesso.", @"Sucesso");
                return true;
            }

            MessageBox.Show(@"Problemas ao cadastrar cliente.", @"Erro");
            return false;
        }
    }
}