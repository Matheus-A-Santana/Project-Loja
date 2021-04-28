using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Data_Transfer_Object
{
    public class Produtos_DTO
    {
        // Categoria
        private int id_categoria;
        private string categoria;
        private string descricao;

        public int Id_Categoria { get { return id_categoria; } set { id_categoria = value; } }
        public string Categoria { get { return categoria; } set { categoria = value; } }
        public string Descricao { get { return descricao; } set { descricao = value; } }
    }
}
