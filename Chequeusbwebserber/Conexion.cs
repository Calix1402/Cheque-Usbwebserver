using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Chequeusbwebserber
{
    class Conexion
    {
        //prpiedades
        private MySqlConnection conn =
            new MySqlConnection(" Server=Localhost; Database= SMIS021821;Uid=root;" +
                "pwd=usbw;SSL Mode=None");
        public MySqlCommand command;

        // abrir conexion 
        public MySqlConnection OpenConnection()
        {
            if (conn.State ==System.Data. ConnectionState.Closed)
            {
                conn.Open(); 
            }
            return conn; 
        }



        // cerrar la conexion 
        public MySqlConnection closeConnection()
        {
            if ( conn.State == System.Data . ConnectionState.Open)
            {
                conn.Close (); 
            }
            return conn; 
        }
    }



}
