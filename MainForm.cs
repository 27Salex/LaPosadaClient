using DevExpress.Printing.Native;
using DevExpress.XtraEditors;
using LaPosadaDAL.Models;
using LaPosadaDAL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPosadaClient
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            AssignClickEventHandlers(this);
        }

        private void AssignClickEventHandlers(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Click += Control_Click;

                // Si el control tiene hijos, llamamos recursivamente a esta función
                if (control.Controls.Count > 0)
                {
                    AssignClickEventHandlers(control);
                }
            }
        }

        // Manejador de evento Click para todos los controles
        private void Control_Click(object sender, EventArgs e)
        {
            afkTimer.Stop();
            afkTimer.Start();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            string password = XtraInputBox.Show("Introduzca la contraseña de administrador.", "Ajustes", "");
            if (password != "LaPosadaAdmin2024")
            {
                alertBox.Show(this, "Ajustes", "La contraseña introducida es incorrecta.");
                return;
            }
            ///
            /// SHOW SETTINGS FORM
            ///
            this.Close();
        }

        private void alertBox_MouseFormEnter(object sender, DevExpress.XtraBars.Alerter.AlertEventArgs e)
        {
            e.AlertForm.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pageControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            pageControl.SelectedTabPage = pageMain;

            gridCategorias.DataSource = ShopHelper.Categorias;
        }

        private void viewCategorias_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            CargarProductos((Categoria)viewCategorias.GetRow(e.Item.RowHandle));
        }

        private void CargarProductos(Categoria categoria)
        {
            gridProductos.DataSource = ShopHelper.Productos.Where(p => p.RidCategoria == categoria.IdCategoria);
            pageControl.SelectedTabPage = pageProductos;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pageControl.SelectedTabPage = pageCategorias;
        }

        private void viewProductos_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            var producto = (Producto)viewProductos.GetRow(e.Item.RowHandle);

            var consum = new Consumicion {RidProducto = producto.IdProducto};

            consum.Cantidad = AmountSelectorForm.ShowAmountForm(producto);

            if (consum.Cantidad == -1) return;

            ShopHelper.Cart.Add(consum);
            SetCartAmount(ShopHelper.Cart.ItemCount);
        }

        public void SetCartAmount(int amount)
        {
            btnCart1.Text = amount.ToString();
            btnCart2.Text = amount.ToString();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            gridCart.DataSource = ShopHelper.Cart.GetItems();
            pageControl.SelectedTabPage = pageCarrito;
            lblPrecio.Text = ShopHelper.Cart.PrecioTotal + "€";
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            bool res = ShopHelper.Cart.CheckOut();
            if (res)
            {
                ShopHelper.Cart.Clear();
                SetCartAmount(0);
                alertBox.Show(this, "Pedido realizado con exito!", "Éxito");
                pageControl.SelectedTabPage = pageMain;
            }
            else
                alertBox.Show(this, "Ha ocurrido un problema al realizar tu pedido, reinténtalo o contacta al bar.", "ERROR");

            
        }

        private void viewCategorias_ItemCustomize(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs e)
        {
            e.Item.GetElementByName("Imagen").Image = ((Categoria)viewCategorias.GetRow(e.RowHandle)).Icon;
        }

        private void viewProductos_ItemCustomize(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs e)
        {
            e.Item.GetElementByName("Imagen").Image = ((Producto)viewProductos.GetRow(e.RowHandle)).Icon;
        }

        private void startPanel_Click(object sender, EventArgs e)
        {
            pageControl.SelectedTabPage = pageCategorias;
            afkTimer.Stop();
            afkTimer.Start();
        }

        private void afkTimer_Tick(object sender, EventArgs e)
        {
            pageControl.SelectedTabPage = pageMain;
            ShopHelper.Cart.Clear();
            SetCartAmount(0);
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            pageControl.SelectedTabPage = pageMain;
            ShopHelper.Cart.Clear();
            SetCartAmount(0);
        }
    }
}
