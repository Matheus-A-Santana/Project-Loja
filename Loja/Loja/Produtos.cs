using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    public class Produtos
    {
        private int id;
        private string produto;
        private byte[] imagem;
        private string descricao;
        private string categoria;
        private int quantidade;
        private decimal custo;
        private decimal venda;

        public int Id { get => id; set => id = value; }
        public string Produto { get => produto; set => produto = value; }
        public byte[] Imagem { get => imagem; set => imagem = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public decimal Custo { get => custo; set => custo = value; }
        public decimal Venda { get => venda; set => venda = value; }
    }
}
