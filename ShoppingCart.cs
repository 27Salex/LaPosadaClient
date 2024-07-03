using LaPosadaDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPosadaClient
{
    public class ShoppingCart
    {
        public List<Consumicion> Consumiciones;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridProductos;
        private DevExpress.XtraEditors.SimpleButton btnCheckOut;

        public int ItemCount => Consumiciones.Count;

        public decimal PrecioTotal
        {
            get 
            {
                decimal total = default(decimal);
                if (Consumiciones.Count > 0)
                    Consumiciones.ForEach(c => total += c.PrecioTotal);
                return total;
            }
            
        }
        public Pedido Pedido;

        public ShoppingCart()
        {
            Clear();
        }


        public void Clear()
        {
            Consumiciones = new List<Consumicion>();
            Pedido = new Pedido();
        }

        public void Add(Consumicion consumicion)
        {
            if (Consumiciones.Select(c => c.RidProducto).Contains(consumicion.RidProducto))
                Consumiciones.FirstOrDefault(c => c.RidProducto == consumicion.RidProducto).Cantidad += consumicion.Cantidad;
            else
            {
                Consumiciones.Add(consumicion);
                consumicion.RidPedido = Pedido.IdPedido;
            }
        }

        public void AddRange(List<Consumicion> consumiciones) => consumiciones.ForEach(c => Add(c));

        public bool CheckOut()
        {
            try
            {
                Pedido.Fecha = DateTime.Now;
                Pedido.Save();
                Consumiciones.ForEach(c => c.Save());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
