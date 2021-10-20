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
    public partial class Cheque10 : Form
    {
        public Cheque10()
        {
            InitializeComponent();
        }

      
        

        private void Cheque10_Load_1(object sender, EventArgs e)
        {
            Cheque Cheque1 = new Cheque();
            Cheque1._Chequeid = 1;
            Cheque1._Banco = " Agricola ";
            Cheque1._Usuario = " Alexis Manuel Calix ";
            Cheque1._Dinero = " 2,000 ";
            Cheque1._Firma = " A... M...C ";

            lstchequeInfo.Items.Add(Cheque1.getchequeInfo());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cheque Cheque1 = new Cheque();

            Cheque1._Chequeid = Convert.ToInt32(textCheque.Text);
            Cheque1._Banco = textBank.Text;
            Cheque1._Usuario = textUsername.Text;
            Cheque1._Dinero = textMoney.Text;
            Cheque1._Firma = textFirm.Text;

            lstchequeInfo .Items.Add(Cheque1.getchequeInfo ());
        }
    }
}
