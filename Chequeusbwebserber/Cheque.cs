using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Chequeusbwebserber
{
    class Cheque
    {
        public int _Chequeid { get; set; }
        public string _Banco { get; set; }
        public string _Usuario { get; set; }
        public string _Dinero { get; set; }
        public string _Firma { get; set; }

        // INSTANCIA DE LA CLASE CRUD 
        Crud crud = new Crud(); 

        //metodo para retornar los registro de  la tabla CHEQUE

        public MySqlDataReader  getAllCheques()
        {
            string query  = "Select Chequeid, Banco, Usuario, Dinero, Firma " +
                "FROM cheque";

            //llamado al metodo select de la clase crud 
            return crud.select(query); 
        }

        public Boolean newEditCheque(string action) 
        {
            if (action == " new ")
            {
                string query = " INSERT INTO   cheque ( Banco , Usuario, Dinero, Firma) VALUES" +
                    "('" + _Banco + "' , '"+ _Usuario + "','" + _Dinero + "','" + _Firma + "')";

                crud.executeQuery (query);
                return true; 

            }
            else if ( action == "edit ")
            {
                string query = " UPADATE cheque SET " +
                    "' Banco ='" + _Banco  + "' Usuario ='" + _Usuario  + "'Dinero '" + _Dinero + 
                    "' Firma '"+ _Firma +  "WHERE" + "chequeid='" + _Chequeid + "";
                crud.executeQuery(query);
                return true; 
            }
            return false;
        }


        public Boolean deleteCheque()
        {
            string query = " DELETE FROM Cheque WHERE chequeid ='" + _Chequeid + "'";
            crud.executeQuery(query);
            return true ; 
        }

        




    }

             
}




