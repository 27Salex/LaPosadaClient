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
            this.Controls.Add(ShopHelper.Cart);
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
            PageControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            PageControl.SelectedTabPage = pageCategorias;

            gridCategorias.DataSource = ShopHelper.Categorias;
        }

        private void viewCategorias_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            CargarProductos((Categoria)viewCategorias.GetRow(e.Item.RowHandle));
        }

        private void CargarProductos(Categoria categoria)
        {
            gridProductos.DataSource = ShopHelper.Productos.Where(p => p.RidCategoria == categoria.IdCategoria);
            PageControl.SelectedTabPage = pageProductos;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PageControl.SelectedTabPage = pageProductos;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PageControl.SelectedTabPage = pageCategorias;
        }

        private void viewProductos_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            var producto = (Producto)viewProductos.GetRow(e.Item.RowHandle);

            ShopHelper.Cart.Add(new Consumicion { RidProducto = producto.IdProducto, Cantidad = 1});
            SetCartAmount(ShopHelper.Cart.ItemCount);
        }

        public void SetCartAmount(int amount)
        {
            btnCart1.Text = amount.ToString();
            btnCart2.Text = amount.ToString();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            ShopHelper.Cart.ShowPopup();
        }
    }
}
