using Loja.Data_Access_Layer;
using Loja.Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Business_Logic_Layer
{
    public class Produtos_BLL
    {
        //passando valores para a camada Data Acess Layer
        public Produtos_DTO Categoria(Produtos_DTO categoria)
        {
            try
            { 
                    return new Produtos_DAL().Categoria(categoria);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
