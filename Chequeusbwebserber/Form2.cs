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
    public partial class Form2 : Form
    {
        private string action = " ";




        public Form2()
        {
            InitializeComponent();
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tabs.TabPages.Remove(tabform);

            fillDataGridView();
            clearDataGridView();

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            tabs.TabPages.Add(tabform);
            tabs.TabPages.Remove(TabData);
            tabs.TabPages[0].Text = " NEW CHEQUE ";
            txtID.Visible = false;
            txtbanco.Focus();
            action = "new ";
            controlsEnable();
            clearControls();

        }

        public void fillDataGridView()
        {
            Cheque cheque = new Cheque();
            dgtCheques.Columns.Add(" Chequeid ", " CHEQUEID ");
            dgtCheques.Columns.Add(" Banco ", " BANCO ");
            dgtCheques.Columns.Add(" Usuario ", " USUARIO ");
            dgtCheques.Columns.Add(" Firma ", " FIRMA ");
            dgtCheques.Columns.Add(" Dinero ", " DINERO ");

            MySqlDataReader dataReader = cheque.getAllCheques();
            while (dataReader.Read())
            {
                dgtCheques.Rows.Add(dataReader.GetValue(0),dataReader.GetValue(1),dataReader.GetValue(2), dataReader.GetValue(3),dataReader.GetValue(4) );

            }



        }

        public void clearDataGridView()
        {
            dgtCheques.Columns.Clear ();
            dgtCheques.Rows.Clear();

        }

        public void controlsDisable()
        {
            txtID.Enabled = false;
            txtbanco.Enabled = false;
            txtusuario.Enabled = false;
            txtdinero.Enabled = false;
            txtfirma.Enabled = false;

        }

        public void controlsEnable()
        {
            txtID.Enabled = false;
            txtbanco.Enabled = true;
            txtusuario.Enabled = true;
            txtdinero.Enabled = true;
            txtfirma.Enabled = true;

        }

        public void clearControls()
        {
            txtID.Text = "";
            txtbanco.Text = "";
            txtusuario.Text = "";
            txtdinero.Text = "";
            txtfirma.Text = "";

        }

        private void dgtCheques_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tabs.TabPages.Remove(tabform);
            tabs.TabPages.Add(TabData);
            tabs.TabPages[0].Text = " EDIT CHEQUE ";

            action = " edit ";
            controlsEnable();

            txtID.Visible = true;
            txtID.ReadOnly = true;
            metroLabelCheque.Visible = true;

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabs.TabPages.Remove(TabData);
            tabs.TabPages.Add(tabform);
            tabs.TabPages[0].Text = " EDIT CHEQUE ";
            controlsEnable();

            txtID.Visible = true;
            txtID.ReadOnly = true;

            txtID.Text = dgtCheques.CurrentRow.Cells[0].Value.ToString();
            txtbanco.Text = dgtCheques.CurrentRow.Cells[1].Value.ToString();
            txtusuario.Text = dgtCheques.CurrentRow.Cells[2].Value.ToString();
            txtdinero.Text = dgtCheques.CurrentRow.Cells[3].Value.ToString();
            txtfirma.Text = dgtCheques.CurrentRow.Cells[4].Value.ToString();

            action = " edit ";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtbanco.Text == "")
            {

                MetroFramework.MetroMessageBox.Show(this, " Debe escribir el Banco  ", "VALIDACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbanco.Focus();
            }
            else
            {
                Cheque cheque = new Cheque();
                if (action == "edit")
                {
                    cheque._Chequeid = Convert.ToInt32(txtID.Text);

                }
                cheque._Banco = txtbanco.Text;
                cheque._Usuario = txtusuario.Text;
                cheque._Dinero = txtdinero.Text;
                cheque._Firma = txtfirma.Text;

                string mensaje = " Desea guardar el registro ?";
                if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (cheque.newEditCheque(action))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos se han guardado exitosamente",
                            "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han guardado",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    clearControls();
                    controlsDisable();
                    fillDataGridView();

                    tabs.TabPages.Remove(tabform);
                    tabs.TabPages.Add(TabData);
                    tabs.TabPages[0].Text = " CHEQUE LIST";


                }


            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea cancelar?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clearControls();
                controlsDisable();


                tabs.TabPages.Remove(tabform);
                tabs.TabPages.Add(TabData);
                tabs.TabPages[0].Text = "CHEQUE  LIST";
            }
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje = "Esta seguro que desea eliminar el registro?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Cheque project = new Cheque();
                project._Chequeid = Convert.ToInt32(dgtCheques.CurrentRow.Cells[0].Value);

                if (project.deleteCheque())
                {
                    MetroFramework.MetroMessageBox.Show(this, "Se han eliminado los datos  exitosamente!",
                      "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    fillDataGridView();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos  no han podido ser eliminados ",
                      "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

                clearControls();
                controlsDisable();
                fillDataGridView();
                tabs.TabPages.Remove(tabform);
                tabs.TabPages.Add(TabData );
                tabs.TabPages[0].Text = " LISTA DE CHEQUES "; 


            }
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
           
        }

        private void tabform_Click(object sender, EventArgs e)
        {

        }

        private void txtbanco_Click(object sender, EventArgs e)
        {

        }
    }
}
