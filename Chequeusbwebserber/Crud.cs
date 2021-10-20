using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace Chequeusbwebserber
{
    class Crud
    {
        //la instancia de la clase conexion 
        private Conexion conn = new Conexion(); 
        
        //metodo para selecionar registro de la tabla de la base de datos 
        public MySqlDataReader select (string query)
        {
            MySqlDataReader dataReader;

            //utilizar command de la clase Conexion  
            conn.command = new MySqlCommand(query, conn.OpenConnection ());//prepara la consulta
            dataReader = conn.command.ExecuteReader(); //ejecuta la consulta 
            return dataReader; 
        }

        public void executeQuery(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            conn.command = new MySqlCommand(query, conn.OpenConnection());
            adapter.InsertCommand = conn.command;
            adapter.InsertCommand.ExecuteNonQuery();
            conn.command.Dispose();
            conn.closeConnection();
        }
         
        
           
        
    }
}
