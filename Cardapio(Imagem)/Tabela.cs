using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cardapio_Imagem_
{
    public class Tabela : Produto
    {
        public Tabela() 
            {
                var file = File.AppendText(@"CC:\Users\2022102020030\source\repos\cardapioPaste\Codigo_Pastelaria\TAbelaCadastrada.docx");
                file.WriteLine(codigo + "|" + descricao + "|" + valor);
                file.Close();
            }
    }
}
