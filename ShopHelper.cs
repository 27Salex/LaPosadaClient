using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPosadaDAL.Models;
using LaPosadaDAL.Services;

namespace LaPosadaClient
{
    public class ShopHelper
    {
        private static List<Categoria> categorias;
        public static List<Categoria> Categorias
        {
            get
            {
                if (categorias == null)
                    categorias = new CategoriaDAL().GetAll();

                return categorias;
            }
        }

        private static List<Producto> productos;
        public static List<Producto> Productos
        {
            get
            {
                if (productos == null)
                    productos = new ProductoDAL().GetAll(null, false);

                return productos;
            }
        }

        public static ShoppingCart cart;

        public static ShoppingCart Cart
        {
            get
            {
                if (cart == null)
                    cart = new ShoppingCart();
                return cart;
            }
        }

    }
}
