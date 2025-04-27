using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUARDERIA
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gUARDERIADataSet6.EMPLEADO' Puede moverla o quitarla según sea necesario.
            this.eMPLEADOTableAdapter.Fill(this.gUARDERIADataSet6.EMPLEADO);

            this.reportViewer1.RefreshReport();
        }
    }
}
