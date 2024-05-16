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

namespace ReservacionesHoteles
{
    public partial class GestionDeReservas : Form
    {
        //Conexion Base de Datos
        public static string baseDatos = "Server=ABITHABONIRYES\\SQLEXPRESS; Database=ReservaHoteles; Integrated Security=True;";

        public GestionDeReservas()
        {
            InitializeComponent();
        }
        private void GestionDeReservas_Load(object sender, EventArgs e)
        {
            string consulta = " select * from habitacion";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, baseDatos);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            DataGridView1.DataSource = dt;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }

     
    }
}
