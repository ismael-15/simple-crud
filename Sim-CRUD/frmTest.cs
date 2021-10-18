using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sim_CRUD
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string connectionString = "";
            MySqlConnection conn;
            try
            {
                connectionString = @"Server=localhost;Database=smis071121; Uid=root; 
                    Pwd=usbw;SSL Mode=None"; //definimos string de conexion
                conn = new MySqlConnection(connectionString); //creamos la conexion
                conn.Open(); //abrimos la conexio a la base de datos
                MetroFramework.MetroMessageBox.Show(this, "Se establecio conexión!", "TEST",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                MetroFramework.MetroMessageBox.Show(this, Ex.Message,
                    "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
