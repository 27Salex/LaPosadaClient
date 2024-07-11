using LaPosadaDAL.Models;
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
    public partial class AmountSelectorForm : Form
    {
        private Producto _Product;

        public Producto Product
        {
            get
            {
                return _Product;
            }
            set
            {
                _Product = value;
                //pictureBox1.Image = Image.FromStream(_Product.Image)
            }

        }


        private int _Amount = 1;
        public int Amount 
        {
            get
            {
                return _Amount;
            }
            set
            {
                _Amount = value;
                lblAmount.Text = _Amount.ToString();
            }
        
        }

        private AmountSelectorForm()
        {
            InitializeComponent();
        }

        private void AmountSelectorForm_Load(object sender, EventArgs e)
        {

        }

        public static int ShowAmountForm()
        {
            AmountSelectorForm form = new AmountSelectorForm();

            form.ShowDialog();

            return form.Amount;
        }

        private void btnMore_Click(object sender, EventArgs e) => Amount++;

        private void btnLess_Click(object sender, EventArgs e)
        {
            if (Amount > 1)
                Amount--;
        }

        private void btnCancel_Click(object s, EventArgs e)
        {
            this.Close();
            Amount = -1;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
