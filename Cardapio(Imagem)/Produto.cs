using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardapio_Imagem_
{
    public class Produto
    {
        public int codigo { get; set; }
        public string descricao { get; set; }    
        public double valor { get; set; }

        public Produto() { }

        public Produto(int codigo, string descricao, double valor)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.valor = valor;
        }   
    }
}
