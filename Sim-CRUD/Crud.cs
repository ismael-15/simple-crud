using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sim_CRUD
{
    class Crud
    {
        //instancia de la clase cnnection
        private Connection conn = new Connection();

        //metodo para seleccionar los registros de la tabla de la base de datos
        public MySqlDataReader select(string query)
        {
            MySqlDataReader dataReader;

            //utilizar command de la clase coonection
            conn.command = new MySqlCommand(query, conn.openConection());
            dataReader = conn.command.ExecuteReader();
            return dataReader;
        }

        public void executeQuery(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            conn.command = new MySqlCommand(query, conn.openConection());
            adapter.InsertCommand = conn.command;
            adapter.InsertCommand.ExecuteNonQuery();
            conn.command.Dispose();
            conn.closeConection();
        }
    

        
    }
}
