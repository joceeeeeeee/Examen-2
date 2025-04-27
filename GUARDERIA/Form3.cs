using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUARDERIA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-8QNTNAJ\MSSQLSERVER01; Initial Catalog=GUARDERIA; integrated security=true");

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gUARDERIADataSet3.EMPLEADO' Puede moverla o quitarla según sea necesario.
            this.eMPLEADOTableAdapter.Fill(this.gUARDERIADataSet3.EMPLEADO);
            // TODO: esta línea de código carga datos en la tabla 'gUARDERIADataSet2.TUTOR' Puede moverla o quitarla según sea necesario.
            this.tUTORTableAdapter.Fill(this.gUARDERIADataSet2.TUTOR);
            // TODO: esta línea de código carga datos en la tabla 'gUARDERIADataSet1.SALON' Puede moverla o quitarla según sea necesario.
            this.sALONTableAdapter.Fill(this.gUARDERIADataSet1.SALON);
            // TODO: esta línea de código carga datos en la tabla 'gUARDERIADataSet.EXPEDIENTE' Puede moverla o quitarla según sea necesario.
            this.eXPEDIENTETableAdapter.Fill(this.gUARDERIADataSet.EXPEDIENTE);
            string consulta = "select * from NINO";

            SqlDataAdapter a = new SqlDataAdapter(consulta, conexion);

            DataTable tabla = new DataTable();
            a.Fill(tabla);
            DataView.DataSource = tabla;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlCommand altas = new SqlCommand
                ("insert into NINO (ID_NI,NOMBRE_NI,GRUPO_NI,CURP_NI,ID_TUTOR,ID_EXPEDIENTE,ID_SALON,ID_EMPLEADO) values (@ID_NI,@NOMBRE_NI,@GRUPO_NI,@CURP_NI,@ID_TUTOR,@ID_EXPEDIENTE,@ID_SALON,@ID_EMPLEADO) ", conexion);
            // se pasan los valores de los text box a las variables temporales
            altas.Parameters.AddWithValue("ID_NI", txtcodigo.Text);
            altas.Parameters.AddWithValue("NOMBRE_NI", txtnombre.Text);
            altas.Parameters.AddWithValue("GRUPO_NI", txtgrupo.Text);
            altas.Parameters.AddWithValue("CURP_NI", txtcurp.Text);
            altas.Parameters.AddWithValue("ID_TUTOR", cbbtutor.Text);
            altas.Parameters.AddWithValue("ID_EXPEDIENTE", cbbexpediente.GetItemText(cbbexpediente.SelectedValue));
            altas.Parameters.AddWithValue("ID_SALON", cbbsalon.GetItemText(cbbsalon.SelectedValue));
            altas.Parameters.AddWithValue("ID_EMPLEADO", cbbempleado.GetItemText(cbbempleado.SelectedValue));
       
            conexion.Open();// se abre la conexion

            altas.ExecuteNonQuery();

            conexion.Close();// se cierra la conexion
            MessageBox.Show("SE GUARDARON DATOS DEL NINO");

            // limpiar los textbox
            txtcodigo.Clear();
            txtnombre.Clear();
            txtgrupo.Clear();
            txtcurp.Clear();
           
            txtcodigo.Focus();

            Form3_Load(0, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("UPDATE NINO SET ID_NI=@ID_NI,NOMBRE_NI=@NOMBRE_NI,GRUPO_NI=@GRUPO_NI,CURP_NI=@CURP_NI,ID_TUTOR=@ID_TUTOR,ID_EXPEDIENTE=@ID_EXPEDIENTE,ID_SALON=@ID_SALON,ID_EMPLEADO=@ID_EMPLEADO " +
                "WHERE ID_NI=@ID_NI", conexion);


            comando.Parameters.AddWithValue("ID_NI", txtcodigo.Text);
            comando.Parameters.AddWithValue("NOMBRE_NI", txtnombre.Text);
            comando.Parameters.AddWithValue("GRUPO_NI", txtgrupo.Text);
            comando.Parameters.AddWithValue("CURP_NI", txtcurp.Text);
            comando.Parameters.AddWithValue("ID_TUTOR", cbbtutor.Text);
            comando.Parameters.AddWithValue("ID_EXPEDIENTE", cbbexpediente.GetItemText(cbbexpediente.SelectedValue));
            comando.Parameters.AddWithValue("ID_SALON", cbbsalon.GetItemText(cbbsalon.SelectedValue));
            comando.Parameters.AddWithValue("ID_EMPLEADO", cbbempleado.GetItemText(cbbempleado.SelectedValue));

            comando.ExecuteNonQuery();



            MessageBox.Show("MODIFICACION COMPLETA");
            conexion.Close();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }

            }
            Form3_Load(0, e);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string baja = "DELETE FROM NINO WHERE ID_NI=@ID_NI";



            SqlCommand cmdIns = new SqlCommand(baja, conexion);


            cmdIns.Parameters.Add("ID_NI", txtcodigo.Text);


            cmdIns.ExecuteNonQuery();

            cmdIns.Dispose();
            cmdIns = null;



            conexion.Close();
            MessageBox.Show("Nino eliminado");
            Form3_Load(0, e);
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand("SELECT * FROM NINO WHERE ID_NI=@ID_NI", conexion);
            conexion.Open();

            consulta.Parameters.AddWithValue("ID_NI", txtcodigo.Text);
            
            SqlDataReader reader = consulta.ExecuteReader();
            while (reader.Read())
            {
               

              
                txtcodigo.Text = reader[0].ToString();
                txtnombre.Text = reader[1].ToString();
                txtgrupo.Text = reader[2].ToString();
                txtcurp.Text = reader[3].ToString();
                cbbexpediente.Text = reader[4].ToString();
                cbbsalon.Text = reader[5].ToString();
                cbbempleado.Text = reader[6].ToString();


            }
            MessageBox.Show("CONSULTA COMPLETA");
            conexion.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
           Form12 f=new Form12();
            f.Show();
        }
    }
}
