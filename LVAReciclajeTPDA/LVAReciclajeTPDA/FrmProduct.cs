using LVAReciclajeTPDA.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LVAReciclajeTPDA
{
    public partial class FrmProduct : MetroFramework.Forms.MetroForm
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                productBindingSource.DataSource =
                    dataContext.Products.ToList();
            }
            pnlDatos.Enabled = false;
            Product product = productBindingSource.Current as Product;
        }
    }
}
