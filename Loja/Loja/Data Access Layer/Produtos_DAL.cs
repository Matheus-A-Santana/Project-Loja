using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using Loja.Data_Transfer_Object;

namespace Loja.Data_Access_Layer
{
    public class Produtos_DAL
    {

        //Adicionar Categoria no banco de dados
        public Produtos_DTO Categoria(Produtos_DTO categoria)
        {
            SqlConnection conexao = new SqlConnection
            {
                ConnectionString = Properties.Settings.Default.conexao
            };

            SqlCommand comando = new SqlCommand("SP_ADD_CATEGORIA", conexao)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            conexao.Open();

            try
            {
                comando.Parameters.AddWithValue("@nome", categoria.Categoria);
                comando.Parameters.AddWithValue("@descricao", categoria.Descricao);

                comando.ExecuteNonQuery();
                conexao.Close();
                return categoria;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
