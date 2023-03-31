using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insercao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void limpar() // isso é uma função
        {
            textBoxID.Clear();
            textBoxProduto.Clear();
            textBoxQuantidade.Clear();
            textBoxPreco.Clear();
            textBoxID.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "") // lembre-se a validação precisa vir primero senão o código não funciona
            {
                MessageBox.Show("O campo ID não pode ser vazio, por favor preencha o campo ID");
                textBoxID.Focus();
                return; // está linha serve para retornar ao campo e não ficar mostrando todas as menssagens em sequência
            }
            if (textBoxProduto.Text == "")
            {
                MessageBox.Show("O campo Produto não pode ser vazio, por favor preencha o campo Produto");
                textBoxProduto.Focus();
                return;
            }
            if (textBoxQuantidade.Text == "")
            {
                MessageBox.Show("O campo Quantidade não pode ser vazio, por favor preencha o campo Quantidade");
                textBoxQuantidade.Focus();
                return;
            }
            if (textBoxPreco.Text == "")
            {
                MessageBox.Show("O campo Preço não pode ser vazio, por favor preencha o campo Preço");
                textBoxPreco.Focus();
                return;
            }

            String[] produtos = new string[4]; // isso é um array
            produtos[0] = textBoxID.Text;
            produtos[1] = textBoxProduto.Text;
            produtos[2] = textBoxQuantidade.Text;
            produtos[3] = textBoxPreco.Text;

            ListViewItem L = new ListViewItem(produtos); // é uma varial não motiovo para ser a letra L poderia ser qualquer outra letra ou nome
            listView.Items.Add(L);
            limpar(); // está linha está chamando a função limpar para limpar os textBox após clicar no botão adicionar
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            listView.Items.RemoveAt(listView.SelectedIndices[0]); // essa linha revome apenas a linha selecionada
        }
    }
}
