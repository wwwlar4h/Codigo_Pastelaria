using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cardapio_Imagem_
{
    public partial class PedidoCalculo : Form
    {
        List<Produto> produtos = new List<Produto>();
        public PedidoCalculo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PedidoCalculo_Load(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.descricao = "Pastéis simples";
            p.valor = 10;
            produtos.Add(p);

            Produto p2 = new Produto();
            p2.descricao = "Pastéis doces";
            p2.valor = 15;
            produtos.Add(p2);

            Produto p3 = new Produto();
            p3.descricao = "Bebidas latas";
            p3.valor = 5;
            produtos.Add(p3);

            Produto p4 = new Produto();
            p4.descricao = "Bebidas litros";
            p4.valor = 10;
            produtos.Add(p4);

            Produto p5 = new Produto();
            p5.descricao = "Bebidas variadas";
            p5.valor = 3;
            produtos.Add(p5);


            comboBox1.DataSource = null;
            comboBox1.DataSource = produtos;
            comboBox1.DisplayMember = "descricao";
            comboBox1.ValueMember = "valor";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(comboBox1.SelectedValue.ToString());

            double v2 = Convert.ToDouble(comboBox1.SelectedValue.ToString());

            double v3 = Convert.ToDouble(comboBox1.SelectedValue.ToString());

           




       
          


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
