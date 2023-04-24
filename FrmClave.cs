using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEV7_David_Alberto
{
    public partial class FrmClave : Form
    {
        FrmMantenimiento frmMantenimiento;

        public FrmClave()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {


            frmMantenimiento = new FrmMantenimiento();
            frmMantenimiento.Show();

            if (frmMantenimiento != null)
            {
                frmMantenimiento.Activate();
            }

            this.Dispose();
        }
    }
}
