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

namespace Chequeusbwebserber
{
    public partial class FmrTest : Form
    {
        public FmrTest()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //prueba de coexion a bases de datos 
            string connectionString = "";
            MySqlConnection conn; 
            try
            {
                connectionString = @"Server=localhost; Database=SMIS021821;Uid=root;pwd=usbw;SSL Mode=None ";

                conn = new MySqlConnection(connectionString);
                conn.Open();

                MetroFramework.MetroMessageBox.Show(this, "Se establecio conexion", 
                    " Conexion Existosa  ", MessageBoxButtons.OK, MessageBoxIcon.Information );

            }
            catch (Exception Ex)
            {
                MetroFramework.MetroMessageBox.Show(this, Ex.Message, " Error ", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
    }
}
