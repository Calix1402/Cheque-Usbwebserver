using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chequeusbwebserber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cheque Cheque1 = new Cheque();
            Cheque1._Chequeid = 1;
            Cheque1._Banco = " Agricola ";
            Cheque1._Usuario = " Alexis Manuel Calix ";
            Cheque1._Dinero = " 2,000 ";
            Cheque1._Firma = " A... M...C ";

            lstchequeInfo.Items.Add(Cheque1.getchequeInfo());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Cheque Cheque1 = new Cheque();

            Cheque1._Chequeid = Convert.ToInt32(textcheque.Text);
            Cheque1._Banco = textbanco.Text;
            Cheque1._Usuario = textusuario.Text;
            Cheque1._Dinero = textdinero.Text;
            Cheque1._Firma = textfirma.Text;

            lstchequeInfo.Items.Add(Cheque1.getchequeInfo());
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
