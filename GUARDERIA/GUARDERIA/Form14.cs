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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gUARDERIADataSet9.TUTOR' Puede moverla o quitarla según sea necesario.
            this.tUTORTableAdapter.Fill(this.gUARDERIADataSet9.TUTOR);

            this.reportViewer1.RefreshReport();
        }
    }
}
