using DevExpress.XtraEditors.FeatureBrowser;
using LaPosadaDAL.Models;
using LaPosadaDAL.Services;
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

        public int ItemCount
        {
            get
            {
                int count = 0;

                foreach (var item in Consumiciones)
                    count += item.Cantidad;

                return count;
            }
        }

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
        public Pedido PedidoActual;

        public decimal TotalPrice
        {
            get
            {
                decimal total = 0;

                foreach (var item in Consumiciones)
                    total += item.PrecioTotal;

                return total;
            }
        }

        public ShoppingCart()
        {
            Clear();
        }


        public void Clear()
        {
            Consumiciones = new List<Consumicion>();
            PedidoActual = new Pedido();
        }

        public void Add(Consumicion consumicion)
        {
            if (Consumiciones.Select(c => c.RidProducto).Contains(consumicion.RidProducto))
                Consumiciones.FirstOrDefault(c => c.RidProducto == consumicion.RidProducto).Cantidad += consumicion.Cantidad;
            else
            {
                Consumiciones.Add(consumicion);
                consumicion.RidPedido = PedidoActual.IdPedido;
            }
        }

        public void AddRange(List<Consumicion> consumiciones) => consumiciones.ForEach(c => Add(c));

        public List<ShopItem> GetItems()
        {
            var items = new List<ShopItem>();
            foreach (var con in Consumiciones)
            {
                var shopItem = new ShopItem();
                shopItem.Producto = con.Producto.Nombre;
                shopItem.Cantidad = con.Cantidad;
                shopItem.Precio = con.PrecioTotal;

                items.Add(shopItem);
            }
            return items;
        }

        public bool CheckOut()
        {
            try
            {
                int idTurno = 0;
                idTurno = new TurnoDAL().GetAll($"WHERE EstaCerrado = 0", true).First().IdTurno;
                if (idTurno != 0)
                {
                    PedidoActual.RidTurno = idTurno;
                    PedidoActual.Fecha = DateTime.Now;
                    PedidoActual.RidEstado = 1;
                    PedidoActual.Save();
                    foreach (var c in Consumiciones)
                    {
                        c.RidPedido = PedidoActual.IdPedido;
                        c.Save();
                    }
                    Clear();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
    public class ShopItem 
    { 
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }

}
