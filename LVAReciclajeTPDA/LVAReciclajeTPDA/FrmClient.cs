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
    public partial class FrmClient : MetroFramework.Forms.MetroForm
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                clientBindingSource.DataSource =
                    dataContext.Client.ToList();
            }
            pnlDatos.Enabled = false;
            Client cliente = clientBindingSource.Current as Client;
        }
    }
}
