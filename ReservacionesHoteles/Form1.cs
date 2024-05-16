using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploProyecto
{
    public partial class Form1 : Form
    {
        //Conexion Base de Datos
        public static string baseDatos = "Server=ABITHABONIRYES\\SQLEXPRESS; Database=ReservaHoteles; Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string consulta = " select * from habitacion";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, baseDatos);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            
            DataGridView1.DataSource = dt;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumHabitacion.Clear();
            txtTipo.Clear();
            txtPrecio.Clear();
            chkDisponibilidad.Checked = false;
            txtNumHabitacion.Focus();



        }
    }
}
