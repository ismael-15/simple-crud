using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Sim_CRUD
{
    class Connection
    {
        //propiedades
        private MySqlConnection conn =
            new MySqlConnection("Server=localhost;Database=smis071121;Uid=root;" +
                "Pwd=usbw;SSL Mode=None");
        public MySqlCommand command;

        //abrimos conexion
        public MySqlConnection openConection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;

        }
        public MySqlConnection closeConection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return conn;
        }
    }
}
