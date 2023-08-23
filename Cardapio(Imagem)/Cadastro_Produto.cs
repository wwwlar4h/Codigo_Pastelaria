using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cardapio_Imagem_
{
    public partial class Cadastro_Produto : Form
    {
        List<Produto> produto = new List<Produto>();
        public Cadastro_Produto()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Produto p = new Produto();

                p.codigo = Convert.ToInt32(codigo.Text);
                p.descricao = descricao.Text;
                p.valor = Convert.ToDouble(valor.Text);

                produto.Add(p);

                tabela.DataSource = null;
                tabela.Refresh();
                tabela.DataSource = produto;

                var file = File.AppendText(@"C:\Users\Master\Documents\Cadastro_produtos\CadastroDeProdutos.docx");
                file.WriteLine(codigo.Text + "|" + descricao.Text + "|" + valor.Text);
                file.Close();

                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            codigo.Clear();
            descricao.Clear();
            valor.Clear();
        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Cadastro_Produto_Load(object sender, EventArgs e)
        {

        }
    }
}
